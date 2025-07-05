# Stable Diffusion API: `/sdapi/v1/txt2img`

## 概要
テキストプロンプトから画像を生成するためのAPIエンドポイントです。

## リクエストメソッド
`POST`

## リクエストURL
`http://127.0.0.1:7860/sdapi/v1/txt2img`

## リクエストボディ (application/json)
```json
{
  /*
    画像生成のためのプロンプト。
    生成される画像の主要な内容を記述します。
    例: "a dog in a park, highly detailed"
  */
  "prompt": "",
  /*
    画像生成から除外するプロンプト。
    生成される画像に含めたくない要素を記述します。
    例: "blurry, low quality, bad anatomy"
  */
  "negative_prompt": "",
  /*
    適用するスタイルのリスト。
    空のままでも良いです。
    例: ["anime style", "fantasy art"]
  */
  "styles": [
    "string"
  ],
  /*
    画像生成のシード値。
    -1はランダムなシードを意味します。同じシード値を使用すると同じ画像を再現できます。
    異なるシード値を使用すると、同じプロンプトでも異なる画像が生成されます。
  */
  "seed": -1,
  /*
    サブシード値。
  */
  "subseed": -1,
  /*
    サブシードの適用強度。
    0から1の範囲で指定します。
  */
  "subseed_strength": 0,
  /*
    シードのリサイズ元高さ。
    -1は無効を意味します。
  */
  "seed_resize_from_h": -1,
  /*
    シードのリサイズ元幅。
    -1は無効を意味します。
  */
  "seed_resize_from_w": -1,
  /*
    使用するサンプラーの名前。
    画像を生成する際のノイズ除去アルゴリズムを指定します。
    `/sdapi/v1/samplers`エンドポイントで取得できるリストから選択します。
    例: "Euler a", "DPM++ 2M Karras"
  */
  "sampler_name": "string",
  /*
    使用するスケジューラーの名前。
    `/sdapi/v1/schedulers`エンドポイントで取得できるリストから選択します。
  */
  "scheduler": "string",
  /*
    一度に生成する画像の数。
  */
  "batch_size": 1,
  /*
    バッチの繰り返し回数。
  */
  "n_iter": 1,
  /*
    画像生成のステップ数。
    ノイズ除去の反復回数を指定します。
    ステップ数が多いほど詳細な画像になりますが、生成時間も長くなります。
    通常20〜100の範囲で指定します。
  */
  "steps": 50,
  /*
    プロンプトへの忠実度（Classifier Free Guidance Scale）。
    プロンプトにどれだけ忠実に画像を生成するかを制御します。
    値を増やすとプロンプトに厳密に従いますが、画像が不自然になったり、アーティファクトが発生しやすくなります。
    値を減らすとプロンプトからの自由度が高まり、より創造的な結果が得られる可能性がありますが、プロンプトとの関連性が薄れることもあります。
    通常7〜12の範囲で指定します。
  */
  "cfg_scale": 7,
  /*
    蒸留モデルのCFGスケール。
  */
  "distilled_cfg_scale": 3.5,
  /*
    生成される画像の幅（ピクセル）。
    通常512、768、1024などの値が使用されます。
  */
  "width": 512,
  /*
    生成される画像の高さ（ピクセル）。
    通常512、768、1024などの値が使用されます。
  */
  "height": 512,
  /*
    顔の復元を有効にするか。
    生成された画像内の顔の品質を向上させます。
    trueまたはfalse。
  */
  "restore_faces": true,
  /*
    タイリング（シームレスなパターン）を有効にするか。
    生成された画像をタイル状に並べたときに、境界線が目立たないようにします。
    背景やテクスチャの生成に役立ちます。
    trueまたはfalse。
  */
  "tiling": true,
  /*
    サンプル画像を保存しないか。
    trueまたはfalse。
  */
  "do_not_save_samples": false,
  /*
    グリッド画像を保存しないか。
    trueまたはfalse。
  */
  "do_not_save_grid": false,
  /*
    DDIMサンプラーのノイズ量。
  */
  "eta": 0,
  /*
    デノイズ強度。
    img2img（画像から画像への変換）で特に重要です。
    元の画像にどれだけノイズを追加し、それを除去するかを制御します。
    値が高いほど元の画像からの変化が大きくなります。
    0から1の範囲で指定します。
  */
  "denoising_strength": 0,
  /*
    S_min_uncond値。
  */
  "s_min_uncond": 0,
  /*
    S_churn値。
  */
  "s_churn": 0,
  /*
    S_tmax値。
  */
  "s_tmax": 0,
  /*
    S_tmin値。
  */
  "s_tmin": 0,
  /*
    S_noise値。
  */
  "s_noise": 0,
  /*
    デフォルト設定を一時的に上書きするオブジェクト。
    例: {"sd_model_checkpoint": "model.safetensors [hash]"}
  */
  "override_settings": {},
  /*
    オーバーライド設定を後で復元するか。
    trueまたはfalse。
  */
  "override_settings_restore_afterwards": true,
  /*
    リファイナーモデルのチェックポイント。
  */
  "refiner_checkpoint": "string",
  /*
    リファイナーに切り替えるステップ数。
  */
  "refiner_switch_at": 0,
  /*
    追加ネットワークを無効にするか。
    trueまたはfalse。
  */
  "disable_extra_networks": false,
  /*
    最初のパスの画像（Base64エンコードされた文字列）。
  */
  "firstpass_image": "string",
  /*
    追加のコメント。
  */
  "comments": {},
  /*
    高解像度修正（Hires. fix）を有効にするか。
    生成された画像の解像度を向上させる機能です。
    trueまたはfalse。
  */
  "enable_hr": false,
  /*
    高解像度修正の最初のフェーズの幅。
  */
  "firstphase_width": 0,
  /*
    高解像度修正の最初のフェーズの高さ。
  */
  "firstphase_height": 0,
  /*
    高解像度修正のスケール。
  */
  "hr_scale": 2,
  /*
    高解像度修正のアップスケーラー。
    `/sdapi/v1/upscalers`エンドポイントで取得できるリストから選択します。
  */
  "hr_upscaler": "string",
  /*
    高解像度修正の2番目のパスのステップ数。
  */
  "hr_second_pass_steps": 0,
  /*
    高解像度修正のリサイズX。
  */
  "hr_resize_x": 0,
  /*
    高解像度修正のリサイズY。
  */
  "hr_resize_y": 0,
  /*
    高解像度修正のチェックポイント名。
  */
  "hr_checkpoint_name": "string",
  /*
    高解像度修正の追加モジュール。
  */
  "hr_additional_modules": [
    "string"
  ],
  /*
    高解像度修正のサンプラー名。
  */
  "hr_sampler_name": "string",
  /*
    高解像度修正のスケジューラー。
  */
  "hr_scheduler": "string",
  /*
    高解像度修正のプロンプト。
  */
  "hr_prompt": "",
  /*
    高解像度修正のネガティブプロンプト。
  */
  "hr_negative_prompt": "",
  /*
    高解像度修正のCFGスケール。
  */
  "hr_cfg": 1,
  /*
    高解像度修正の蒸留CFGスケール。
  */
  "hr_distilled_cfg": 3.5,
  /*
    強制するタスクID。
  */
  "force_task_id": "string",
  /*
    使用するサンプラーのインデックス。
    `sampler_name`が優先されます。
  */
  "sampler_index": "Euler",
  /*
    実行するスクリプトの名前。
  */
  "script_name": "string",
  /*
    スクリプトに渡す引数のリスト。
  */
  "script_args": [],
  /*
    生成された画像をBase64エンコードされた形式で返すか。
    trueまたはfalse。
  */
  "send_images": true,
  /*
    生成された画像をサーバーに保存するか。
    trueまたはfalse。
  */
  "save_images": false,
  /*
    常時実行されるスクリプトの設定。
  */
  "alwayson_scripts": {},
  /*
    画像に関する情報テキスト。
  */
  "infotext": "string"
}
```

## レスポンス (200 Successful Response)
```json
{
  /*
    生成された画像のBase64エンコードされた文字列の配列。
    各文字列はPNGまたはJPEG形式の画像データです。
  */
  "images": [
    "iVBORw0KGgoAAAANSUhEUgAAAgAAAAIACAIAAAB7GkOtAAAA7XRFWHRwYXJhbWV0ZXJzAGEgY2F0IHNpdHRpbmcgb24gYSBiZW5jaApTdGVwczogMjAsIFNhbXBsZXI6IEV1bGVyLCBTY2hlZHVsZSB0eXBlOiBBdXRvbWF0aWMsIENGRyBzY2FsZTog..."
  ],
  /*
    画像生成に使用されたリクエストパラメータのオブジェクト。
  */
  "parameters": {
    "prompt": "a cat sitting on a bench",
    "negative_prompt": "",
    "steps": 20,
    "width": 512,
    "height": 512,
    "override_settings": {
      "sd_model_checkpoint": "cyberrealisticPony_v10.safetensors [8f79fac053]"
    }
  },
  /*
    画像に関する追加情報を含む文字列。
    通常、生成パラメータの要約が含まれます。
  */
  "info": "string"
}
