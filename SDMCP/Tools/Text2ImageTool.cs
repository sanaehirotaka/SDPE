using Microsoft.Extensions.AI;
using ModelContextProtocol;
using ModelContextProtocol.Protocol;
using ModelContextProtocol.Server;
using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SDMCP.Tools;

[McpServerToolType]
public class Text2ImageTool
{
    private readonly HttpClient _httpClient;
    private readonly Txt2ImgDefaults _defaults;
    private readonly string _baseUrl;

    public Text2ImageTool(IConfiguration configuration)
    {
        _httpClient = new HttpClient();
        var stableDiffusionSettings = configuration.GetSection("StableDiffusionSettings").Get<StableDiffusionSettings>() ?? new StableDiffusionSettings();
        _defaults = stableDiffusionSettings.Txt2ImgDefaults;
        _baseUrl = stableDiffusionSettings.BaseUrl;
    }

    [McpServerTool, Description("Stable Diffusion Web UI APIを使用して、指定されたプロンプトから画像を生成します。ネガティブプロンプトやその他の画像生成パラメータも指定できます。")]
    public async Task<IEnumerable<AIContent>> Txt2Img(string prompt, string? negativePrompt)
    {
        Text2ImageRequest request = new()
        {
            Prompt = prompt,
            NegativePrompt = negativePrompt ?? "",
            Steps = _defaults.Steps,
            CfgScale = _defaults.CfgScale,
            Width = _defaults.Width,
            Height = _defaults.Height,
            SamplerName = _defaults.SamplerName,
            Seed = _defaults.Seed,
            RestoreFaces = _defaults.RestoreFaces,
            Tiling = _defaults.Tiling,
            EnableHr = _defaults.EnableHr,
            HrScale = _defaults.HrScale,
            HrUpscaler = _defaults.HrUpscaler,
            HrSecondPassSteps = _defaults.HrSecondPassSteps,
            DenoisingStrength = _defaults.DenoisingStrength,
            OverrideSettings = _defaults.OverrideSettings
        };

        var url = $"{_baseUrl}/sdapi/v1/txt2img";
        var response = await _httpClient.PostAsJsonAsync(url, request);
        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<Text2ImageResponse>();

        return result?.Images.Select(img => new ImageContentBlock() { MimeType = "image/png", Data = img })
            .Select(img => img.ToAIContent()!)
            .ToList() ?? [];
    }
}

public class StableDiffusionSettings
{
    public string BaseUrl { get; set; } = "http://127.0.0.1:7860";
    public Txt2ImgDefaults Txt2ImgDefaults { get; set; } = new Txt2ImgDefaults();
}

public class Txt2ImgDefaults
{
    public int Steps { get; set; }
    public double CfgScale { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string SamplerName { get; set; } = "Euler a";
    public int Seed { get; set; }
    public bool RestoreFaces { get; set; }
    public bool Tiling { get; set; }
    public bool EnableHr { get; set; }
    public double HrScale { get; set; }
    public string HrUpscaler { get; set; } = "Latent";
    public int HrSecondPassSteps { get; set; }
    public double DenoisingStrength { get; set; }
    public OverrideSettings OverrideSettings { get; set; } = new OverrideSettings();
}

public class Text2ImageRequest
{
    [JsonPropertyName("prompt")]
    public string Prompt { get; set; } = "";

    [JsonPropertyName("negative_prompt")]
    public string NegativePrompt { get; set; } = "";

    // appsettings.jsonから読み込むデフォルト値
    [JsonPropertyName("steps")]
    public int Steps { get; set; }
    [JsonPropertyName("cfg_scale")]
    public double CfgScale { get; set; }
    [JsonPropertyName("width")]
    public int Width { get; set; }
    [JsonPropertyName("height")]
    public int Height { get; set; }
    [JsonPropertyName("sampler_name")]
    public string SamplerName { get; set; } = "";
    [JsonPropertyName("seed")]
    public int Seed { get; set; }
    [JsonPropertyName("restore_faces")]
    public bool RestoreFaces { get; set; }
    [JsonPropertyName("tiling")]
    public bool Tiling { get; set; }
    [JsonPropertyName("enable_hr")]
    public bool EnableHr { get; set; }
    [JsonPropertyName("hr_scale")]
    public double HrScale { get; set; }
    [JsonPropertyName("hr_upscaler")]
    public string HrUpscaler { get; set; } = "";
    [JsonPropertyName("hr_second_pass_steps")]
    public int HrSecondPassSteps { get; set; }
    [JsonPropertyName("denoising_strength")]
    public double DenoisingStrength { get; set; }

    [JsonPropertyName("override_settings")]
    public OverrideSettings OverrideSettings { get; set; } = new OverrideSettings();
}

public class Text2ImageResponse
{
    [JsonPropertyName("images")]
    public string[] Images { get; set; } = [];

    [JsonPropertyName("parameters")]
    public JsonElement Parameters { get; set; }

    [JsonPropertyName("info")]
    public string Info { get; set; } = "";
}

public class OverrideSettings
{
    [JsonPropertyName("sd_model_checkpoint")]
    public string SdModelCheckpoint { get; set; } = "";
}
