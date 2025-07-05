# Stable Diffusion API: `/sdapi/v1/options`

## 概要
Stable Diffusionの現在の設定を取得するためのAPIエンドポイントです。

## リクエストメソッド
`GET`

## リクエストURL
`http://127.0.0.1:7860/sdapi/v1/options`

## リクエストボディ
なし

## レスポンス (200 Successful Response)
```json
{
  /*
    生成されたサンプル画像を保存するかどうか。
    型: boolean (true/false)
  */
  "samples_save": true,
  /*
    サンプル画像の保存形式（例: "png", "jpeg"）。
    型: string (例: "png", "jpeg", "webp")
  */
  "samples_format": "png",
  /*
    サンプル画像のファイル名パターン。
    型: string (例: "[seed]-[prompt_words]")
  */
  "samples_filename_pattern": "",
  /*
    保存する画像に連番を追加するかどうか。
    型: boolean (true/false)
  */
  "save_images_add_number": true,
  /*
    画像の保存時の置き換えアクション（例: "Replace"）。
    型: string (例: "Replace", "Add number")
  */
  "save_images_replace_action": "Replace",
  /*
    グリッド画像を保存するかどうか。
    型: boolean (true/false)
  */
  "grid_save": true,
  /*
    グリッド画像の保存形式。
    型: string (例: "png", "jpeg")
  */
  "grid_format": "png",
  /*
    グリッド画像の拡張ファイル名を使用するかどうか。
    型: boolean (true/false)
  */
  "grid_extended_filename": false,
  /*
    複数の画像がある場合のみグリッドを保存するかどうか。
    型: boolean (true/false)
  */
  "grid_only_if_multiple": true,
  /*
    グリッドの空きスポットを防ぐかどうか。
    型: boolean (true/false)
  */
  "grid_prevent_empty_spots": false,
  /*
    グリッドのZIPファイル名パターン。
    型: string
  */
  "grid_zip_filename_pattern": "",
  /*
    グリッドの行数。
    型: integer (-1は自動)
  */
  "n_rows": -1,
  /*
    使用するフォント。
    型: string (フォント名)
  */
  "font": "",
  /*
    グリッドのアクティブなテキストの色。
    型: string (CSSカラーコード、例: "#000000")
  */
  "grid_text_active_color": "#000000",
  /*
    グリッドの非アクティブなテキストの色。
    型: string (CSSカラーコード)
  */
  "grid_text_inactive_color": "#999999",
  /*
    グリッドの背景色。
    型: string (CSSカラーコード)
  */
  "grid_background_color": "#ffffff",
  /*
    顔の復元前に画像を保存するかどうか。
    型: boolean (true/false)
  */
  "save_images_before_face_restoration": false,
  /*
    高解像度修正前に画像を保存するかどうか。
    型: boolean (true/false)
  */
  "save_images_before_highres_fix": false,
  /*
    色補正前に画像を保存するかどうか。
  */
  "save_images_before_color_correction": false,
  /*
    マスクを保存するかどうか。
    型: boolean (true/false)
  */
  "save_mask": false,
  /*
    合成マスクを保存するかどうか。
    型: boolean (true/false)
  */
  "save_mask_composite": false,
  /*
    JPEGの品質。
    型: integer (0-100)
  */
  "jpeg_quality": 80,
  /*
    WebPをロスレスで保存するかどうか。
    型: boolean (true/false)
  */
  "webp_lossless": false,
  /*
    4chan向けにエクスポートするかどうか。
    型: boolean (true/false)
  */
  "export_for_4chan": true,
  /*
    画像のダウンスケール閾値。
    型: number
  */
  "img_downscale_threshold": 4,
  /*
    ターゲットのサイド長。
    型: integer
  */
  "target_side_length": 4000,
  /*
    画像の最大サイズ（メガピクセル）。
    型: integer
  */
  "img_max_size_mp": 200,
  /*
    バッチ処理で元のファイル名を使用するかどうか。
    型: boolean (true/false)
  */
  "use_original_name_batch": true,
  /*
    アップスケーラー名をサフィックスとして使用するかどうか。
    型: boolean (true/false)
  */
  "use_upscaler_name_as_suffix": false,
  /*
    選択した画像のみを保存するかどうか。
    型: boolean (true/false)
  */
  "save_selected_only": true,
  /*
    ログCSVを保存するかどうか。
    型: boolean (true/false)
  */
  "save_write_log_csv": true,
  /*
    初期画像を保存するかどうか。
    型: boolean (true/false)
  */
  "save_init_img": false,
  /*
    一時ディレクトリ。
    型: string (パス)
  */
  "temp_dir": "",
  /*
    起動時に一時ディレクトリをクリーンアップするかどうか。
    型: boolean (true/false)
  */
  "clean_temp_dir_at_start": false,
  /*
    不完全な画像を保存するかどうか。
    型: boolean (true/false)
  */
  "save_incomplete_images": false,
  /*
    通知音を有効にするか。
    型: boolean (true/false)
  */
  "notification_audio": true,
  /*
    通知音量。
    型: integer (0-100)
  */
  "notification_volume": 100,
  /*
    サンプル出力ディレクトリ。
    型: string (パス)
  */
  "outdir_samples": "",
  /*
    txt2imgのサンプル出力ディレクトリ。
    型: string (パス)
  */
  "outdir_txt2img_samples": "outputs\\\\txt2img-images",
  /*
    img2imgのサンプル出力ディレクトリ。
    型: string (パス)
  */
  "outdir_img2img_samples": "outputs\\\\img2img-images",
  /*
    extrasのサンプル出力ディレクトリ。
    型: string (パス)
  */
  "outdir_extras_samples": "outputs\\\\extras-images",
  /*
    グリッド出力ディレクトリ。
    型: string (パス)
  */
  "outdir_grids": "",
  /*
    txt2imgのグリッド出力ディレクトリ。
    型: string (パス)
  */
  "outdir_txt2img_grids": "outputs\\\\txt2img-grids",
  /*
    img2imgのグリッド出力ディレクトリ。
    型: string (パス)
  */
  "outdir_img2img_grids": "outputs\\\\img2img-grids",
  /*
    保存ディレクトリ。
    型: string (パス)
  */
  "outdir_save": "log\\\\images",
  /*
    初期画像出力ディレクトリ。
    型: string (パス)
  */
  "outdir_init_images": "outputs\\\\init-images",
  /*
    ディレクトリに保存するかどうか。
    型: boolean (true/false)
  */
  "save_to_dirs": true,
  /*
    グリッドをディレクトリに保存するかどうか。
    型: boolean (true/false)
  */
  "grid_save_to_dirs": true,
  /*
    UIでディレクトリ保存を使用するかどうか。
    型: boolean (true/false)
  */
  "use_save_to_dirs_for_ui": false,
  /*
    ディレクトリのファイル名パターン。
    型: string (例: "[date]", "[prompt_words]")
  */
  "directories_filename_pattern": "[date]",
  /*
    ディレクトリのプロンプト単語の最大数。
    型: integer
  */
  "directories_max_prompt_words": 8,
  /*
    ESRGANのタイルサイズ。
    型: integer
  */
  "ESRGAN_tile": 192,
  /*
    ESRGANのタイルオーバーラップ。
    型: integer
  */
  "ESRGAN_tile_overlap": 8,
  /*
    有効なReal-ESRGANモデルのリスト。
    型: array of string (モデル名)
  */
  "realesrgan_enabled_models": [
    "R-ESRGAN 4x+",
    "R-ESRGAN 4x+ Anime6B"
  ],
  /*
    有効なDATモデルのリスト。
    型: array of string (モデル名)
  */
  "dat_enabled_models": [
    "DAT x2",
    "DAT x3",
    "DAT x4"
  ],
  /*
    DATのタイルサイズ。
    型: integer
  */
  "DAT_tile": 192,
  /*
    DATのタイルオーバーラップ。
    型: integer
  */
  "DAT_tile_overlap": 8,
  /*
    img2img用のアップスケーラー。
    型: string (アップスケーラー名)
  */
  "upscaler_for_img2img": "string",
  /*
    アップスケーラー変更時にスケールを設定するかどうか。
    型: boolean (true/false)
  */
  "set_scale_by_when_changing_upscaler": false,
  /*
    顔の復元を有効にするか。
    型: boolean (true/false)
  */
  "face_restoration": false,
  /*
    顔の復元モデル。
    型: string (モデル名、例: "CodeFormer", "GFPGAN")
  */
  "face_restoration_model": "CodeFormer",
  /*
    CodeFormerの重み。
    型: number (0.0-1.0)
  */
  "code_former_weight": 0.5,
  /*
    顔の復元モデルをアンロードするかどうか。
    型: boolean (true/false)
  */
  "face_restoration_unload": false,
  /*
    ブラウザを自動起動するかどうか。
    型: string (例: "Local", "None")
  */
  "auto_launch_browser": "Local",
  /*
    コンソールプロンプトを有効にするか。
    型: boolean (true/false)
  */
  "enable_console_prompts": false,
  /*
    警告を表示するかどうか。
    型: boolean (true/false)
  */
  "show_warnings": false,
  /*
    Gradioの非推奨警告を表示するかどうか。
    型: boolean (true/false)
  */
  "show_gradio_deprecation_warnings": true,
  /*
    メモリモニターのポーリングレート。
    型: integer (秒)
  */
  "memmon_poll_rate": 8,
  /*
    サンプルを標準出力にログ出力するかどうか。
    型: boolean (true/false)
  */
  "samples_log_stdout": false,
  /*
    複数のtqdmプログレスバーを表示するかどうか。
    型: boolean (true/false)
  */
  "multiple_tqdm": true,
  /*
    アップスケールプログレスバーを有効にするか。
    型: boolean (true/false)
  */
  "enable_upscale_progressbar": true,
  /*
    ハイパーネットの追加情報を表示するかどうか。
    型: boolean (true/false)
  */
  "print_hypernet_extra": false,
  /*
    隠しファイルを表示するかどうか。
    型: boolean (true/false)
  */
  "list_hidden_files": true,
  /*
    safetensorsのmmapロードを無効にするか。
    型: boolean (true/false)
  */
  "disable_mmap_load_safetensors": false,
  /*
    LDMの出力を非表示にするか。
    型: boolean (true/false)
  */
  "hide_ldm_prints": true,
  /*
    シグナルでスタックダンプを生成するかどうか。
    型: boolean (true/false)
  */
  "dump_stacks_on_signal": false,
  /*
    プロファイリングの説明。
    型: string (HTMLを含む)
  */
  "profiling_explanation": "Those settings allow you to enable torch profiler when generating pictures.\\nProfiling allows you to see which code uses how much of computer's resources during generation.\\nEach generation writes its own profile to one file, overwriting previous.\\nThe file can be viewed in <a href=\\\"chrome:tracing\\\">Chrome</a>, or on a <a href=\\\"https://ui.perfetto.dev/\\\">Perfetto</a> web site.\\nWarning: writing profile can take a lot of time, up to 30 seconds, and the file itelf can be around 500MB in size.",
  /*
    プロファイリングを有効にするか。
    型: boolean (true/false)
  */
  "profiling_enable": false,
  /*
    プロファイリングするアクティビティのリスト。
    型: array of string (例: "CPU", "CUDA")
  */
  "profiling_activities": [
    "CPU"
  ],
  /*
    プロファイリングでシェイプを記録するかどうか。
    型: boolean (true/false)
  */
  "profiling_record_shapes": true,
  /*
    プロファイリングでメモリをプロファイルするかどうか。
    型: boolean (true/false)
  */
  "profiling_profile_memory": true,
  /*
    プロファイリングでスタックを記録するかどうか。
  */
  "profiling_with_stack": true,
  /*
    プロファイリングのファイル名。
    型: string (ファイル名)
  */
  "profiling_filename": "trace.json",
  /*
    APIリクエストを有効にするか。
    型: boolean (true/false)
  */
  "api_enable_requests": true,
  /*
    APIでローカルリクエストを禁止するか。
    型: boolean (true/false)
  */
  "api_forbid_local_requests": true,
  /*
    APIのユーザーエージェント。
    型: string
  */
  "api_useragent": "",
  /*
    トレーニング時にモデルをアンロードするかどうか。
    型: boolean (true/false)
  */
  "unload_models_when_training": false,
  /*
    メモリをピン留めするかどうか。
    型: boolean (true/false)
  */
  "pin_memory": false,
  /*
    オプティマイザの状態を保存するかどうか。
    型: boolean (true/false)
  */
  "save_optimizer_state": false,
  /*
    トレーニング設定をtxtファイルに保存するかどうか。
    型: boolean (true/false)
  */
  "save_training_settings_to_txt": true,
  /*
    データセットのファイル名単語の正規表現。
    型: string (正規表現)
  */
  "dataset_filename_word_regex": "",
  /*
    データセットのファイル名結合文字列。
    型: string
  */
  "dataset_filename_join_string": " ",
  /*
    エポックあたりのトレーニング画像の繰り返し回数。
    型: integer
  */
  "training_image_repeats_per_epoch": 1,
  /*
    CSVへの書き込み頻度。
    型: integer (ステップ数)
  */
  "training_write_csv_every": 500,
  /*
    トレーニングのクロスアテンション最適化を有効にするか。
    型: boolean (true/false)
  */
  "training_xattention_optimizations": false,
  /*
    TensorBoardを有効にするか。
    型: boolean (true/false)
  */
  "training_enable_tensorboard": false,
  /*
    TensorBoardで画像を保存するかどうか。
    型: boolean (true/false)
  */
  "training_tensorboard_save_images": false,
  /*
    TensorBoardのフラッシュ頻度。
    型: integer (秒)
  */
  "training_tensorboard_flush_every": 120,
  /*
    Stable Diffusionモデルのチェックポイント。
    型: string (モデル名またはパス)
  */
  "sd_model_checkpoint": "string",
  /*
    Stable Diffusionチェックポイントの制限。
    型: integer
  */
  "sd_checkpoints_limit": 1,
  /*
    Stable DiffusionチェックポイントをCPUに保持するかどうか。
    型: boolean (true/false)
  */
  "sd_checkpoints_keep_in_cpu": true,
  /*
    Stable Diffusionチェックポイントキャッシュ。
    型: string (例: "0")
  */
  "sd_checkpoint_cache": "0",
  /*
    Stable Diffusion UNet。
    型: string (例: "Automatic")
  */
  "sd_unet": "Automatic",
  /*
    量子化を有効にするか。
    型: boolean (true/false)
  */
  "enable_quantization": false,
  /*
    強調のタイプ。
    型: string (例: "Original")
  */
  "emphasis": "Original",
  /*
    バッチシードを有効にするか。
    型: boolean (true/false)
  */
  "enable_batch_seeds": true,
  /*
    カンマパディングのバックトラック数。
    型: integer
  */
  "comma_padding_backtrack": 20,
  /*
    SDXL CLIP Lスキップを有効にするか。
    型: boolean (true/false)
  */
  "sdxl_clip_l_skip": false,
  /*
    CLIPを最後のレイヤーで停止するか。
    型: integer
  */
  "CLIP_stop_at_last_layers": 1,
  /*
    アテンションをアップキャストするか。
    型: boolean (true/false)
  */
  "upcast_attn": false,
  /*
    乱数生成元。
    型: string (例: "GPU", "CPU")
  */
  "randn_source": "GPU",
  /*
    タイリングを有効にするか。
    型: boolean (true/false)
  */
  "tiling": false,
  /*
    高解像度修正のリファイナーパス。
    型: string (例: "second pass")
  */
  "hires_fix_refiner_pass": "second pass",
  /*
    SDXLクロップ上部。
    型: string (ピクセル数)
  */
  "sdxl_crop_top": "0",
  /*
    SDXLクロップ左部。
  */
  "sdxl_crop_left": "0",
  /*
    SDXLリファイナーの低美的スコア。
    型: number
  */
  "sdxl_refiner_low_aesthetic_score": 2.5,
  /*
    SDXLリファイナーの高美的スコア。
  */
  "sdxl_refiner_high_aesthetic_score": 6,
  /*
    SD3でT5を有効にするか。
  */
  "sd3_enable_t5": false,
  /*
    Stable Diffusion VAEの説明。
    型: string (HTMLを含む)
  */
  "sd_vae_explanation": "<abbr title='Variational autoencoder'>VAE</abbr> is a neural network that transforms a standard <abbr title='red/green/blue'>RGB</abbr>\\nimage into latent space representation and back. Latent space representation is what stable diffusion is working on during sampling\\n(i.e. when the progress bar is between empty and full). For txt2img, VAE is used to create a resulting image after the sampling is finished.\\nFor img2img, VAE is used to process user's input image before the sampling, and to create an image after sampling.",
  /*
    Stable Diffusion VAEチェックポイントキャッシュ。
  */
  "sd_vae_checkpoint_cache": "0",
  /*
    Stable Diffusion VAE。
  */
  "sd_vae": "Automatic",
  /*
    モデルごとのVAEオーバーライド設定を優先するかどうか。
    型: boolean (true/false)
  */
  "sd_vae_overrides_per_model_preferences": true,
  /*
    自動VAE精度をbfloat16にするか。
  */
  "auto_vae_precision_bfloat16": false,
  /*
    自動VAE精度を有効にするか。
  */
  "auto_vae_precision": true,
  /*
    Stable Diffusion VAEエンコードメソッド。
  */
  "sd_vae_encode_method": "Full",
  /*
    Stable Diffusion VAEデコードメソッド。
  */
  "sd_vae_decode_method": "Full",
  /*
    インペインティングマスクの重み。
  */
  "inpainting_mask_weight": 1,
  /*
    初期ノイズ乗数。
  */
  "initial_noise_multiplier": 1,
  /*
    img2imgの追加ノイズ。
  */
  "img2img_extra_noise": "0",
  /*
    img2imgの色補正を有効にするか。
  */
  "img2img_color_correction": false,
  /*
    img2imgのステップを固定するか。
  */
  "img2img_fix_steps": false,
  /*
    img2imgの背景色。
  */
  "img2img_background_color": "#ffffff",
  /*
    img2imgスケッチのデフォルトブラシ色。
  */
  "img2img_sketch_default_brush_color": "#ffffff",
  /*
    img2imgインペイントマスクのブラシ色。
  */
  "img2img_inpaint_mask_brush_color": "#ffffff",
  /*
    img2imgインペイントスケッチのデフォルトブラシ色。
  */
  "img2img_inpaint_sketch_default_brush_color": "#ffffff",
  /*
    img2imgインペイントマスクの高コントラストを有効にするか。
  */
  "img2img_inpaint_mask_high_contrast": true,
  /*
    img2imgインペイントマスクのスクリブルアルファ。
  */
  "img2img_inpaint_mask_scribble_alpha": 75,
  /*
    マスクを返すか。
  */
  "return_mask": false,
  /*
    合成マスクを返すか。
  */
  "return_mask_composite": false,
  /*
    img2imgバッチの結果表示制限。
  */
  "img2img_batch_show_results_limit": 32,
  /*
    インペイントオーバーレイを有効にするか。
  */
  "overlay_inpaint": true,
  /*
    img2imgの自動サイズ調整を有効にするか。
  */
  "img2img_autosize": false,
  /*
    img2imgバッチで元のファイル名を使用するか。
  */
  "img2img_batch_use_original_name": false,
  /*
    クロスアテンション最適化。
  */
  "cross_attention_optimization": "Automatic",
  /*
    S_min_uncond値。
  */
  "s_min_uncond": "0",
  /*
    すべてのS_min_uncondを有効にするか。
  */
  "s_min_uncond_all": false,
  /*
    トークンマージング比率。
  */
  "token_merging_ratio": "0",
  /*
    img2imgのトークンマージング比率。
  */
  "token_merging_ratio_img2img": "0",
  /*
    HRのトークンマージング比率。
  */
  "token_merging_ratio_hr": "0",
  /*
    条件付き/非条件付きパディングを有効にするか。
  */
  "pad_cond_uncond": false,
  /*
    条件付き/非条件付きパディングv0を有効にするか。
  */
  "pad_cond_uncond_v0": false,
  /*
    永続的な条件付きキャッシュを有効にするか。
  */
  "persistent_cond_cache": true,
  /*
    バッチ条件付き/非条件付きを有効にするか。
  */
  "batch_cond_uncond": true,
  /*
    FP8ストレージ。
  */
  "fp8_storage": "Disable",
  /*
    FP16ウェイトをキャッシュするか。
  */
  "cache_fp16_weight": false,
  /*
    Forgeの再現を試みるか。
  */
  "forge_try_reproduce": "None",
  /*
    自動後方互換性を有効にするか。
  */
  "auto_backcompat": true,
  /*
    古い強調実装を使用するか。
  */
  "use_old_emphasis_implementation": false,
  /*
    古いKarrasスケジューラーシグマを使用するか。
  */
  "use_old_karras_scheduler_sigmas": false,
  /*
    DPM++ SDEのバッチ決定論を無効にするか。
  */
  "no_dpmpp_sde_batch_determinism": false,
  /*
    古い高解像度修正の幅/高さを使用するか。
  */
  "use_old_hires_fix_width_height": false,
  /*
    高解像度修正でファーストパスの条件を使用するか。
  */
  "hires_fix_use_firstpass_conds": false,
  /*
    古いスケジューリングを使用するか。
  */
  "use_old_scheduling": false,
  /*
    ダウンキャストされたアルファバーを使用するか。
  */
  "use_downcasted_alpha_bar": false,
  /*
    リファイナーをサンプルステップで切り替えるか。
  */
  "refiner_switch_by_sample_steps": false,
  /*
    Interrogateモデルをメモリに保持するか。
  */
  "interrogate_keep_models_in_memory": false,
  /*
    Interrogateでランクを返すか。
  */
  "interrogate_return_ranks": false,
  /*
    Interrogate CLIPのビーム数。
  */
  "interrogate_clip_num_beams": 1,
  /*
    Interrogate CLIPの最小長。
  */
  "interrogate_clip_min_length": 24,
  /*
    Interrogate CLIPの最大長。
  */
  "interrogate_clip_max_length": 48,
  /*
    Interrogate CLIPの辞書制限。
  */
  "interrogate_clip_dict_limit": 1500,
  /*
    Interrogate CLIPでスキップするカテゴリ。
  */
  "interrogate_clip_skip_categories": [],
  /*
    Interrogate DeepBooruのスコア閾値。
  */
  "interrogate_deepbooru_score_threshold": 0.5,
  /*
    DeepBooruのソートをアルファベット順にするか。
  */
  "deepbooru_sort_alpha": true,
  /*
    DeepBooruでスペースを使用するか。
  */
  "deepbooru_use_spaces": true,
  /*
    DeepBooruでエスケープ文字を使用するか。
  */
  "deepbooru_escape": true,
  /*
    DeepBooruでフィルタリングするタグ。
  */
  "deepbooru_filter_tags": "",
  /*
    追加ネットワークの隠しディレクトリを表示するか。
  */
  "extra_networks_show_hidden_directories": true,
  /*
    追加ネットワークのディレクトリボタン機能。
  */
  "extra_networks_dir_button_function": false,
  /*
    追加ネットワークの隠しモデル。
  */
  "extra_networks_hidden_models": "When searched",
  /*
    追加ネットワークのデフォルト乗数。
  */
  "extra_networks_default_multiplier": 1,
  /*
    追加ネットワークのカード幅。
  */
  "extra_networks_card_width": "0",
  /*
    追加ネットワークのカード高さ。
  */
  "extra_networks_card_height": "0",
  /*
    追加ネットワークのカードテキストスケール。
  */
  "extra_networks_card_text_scale": 1,
  /*
    追加ネットワークのカード説明を表示するか。
  */
  "extra_networks_card_show_desc": true,
  /*
    追加ネットワークのカード説明がHTMLかどうか。
  */
  "extra_networks_card_description_is_html": false,
  /*
    追加ネットワークのカード順序フィールド。
  */
  "extra_networks_card_order_field": "Path",
  /*
    追加ネットワークのカード順序。
  */
  "extra_networks_card_order": "Ascending",
  /*
    追加ネットワークのツリービューのスタイル。
  */
  "extra_networks_tree_view_style": "Dirs",
  /*
    追加ネットワークのツリービューをデフォルトで有効にするか。
  */
  "extra_networks_tree_view_default_enabled": true,
  /*
    追加ネットワークのツリービューのデフォルト幅。
  */
  "extra_networks_tree_view_default_width": 180,
  /*
    追加ネットワークのテキストセパレータ。
  */
  "extra_networks_add_text_separator": " ",
  /*
    UIの追加ネットワークタブの並べ替え。
  */
  "ui_extra_networks_tab_reorder": [],
  /*
    テキスト反転をロード時に表示するか。
  */
  "textual_inversion_print_at_load": false,
  /*
    テキスト反転のハッシュをinfotextに追加するか。
  */
  "textual_inversion_add_hashes_to_infotext": true,
  /*
    Stable Diffusionハイパーネットワーク。
  */
  "sd_hypernetwork": "None",
  /*
    キー編集のアテンション精度。
  */
  "keyedit_precision_attention": 0.1,
  /*
    キー編集の追加精度。
  */
  "keyedit_precision_extra": 0.05,
  /*
    キー編集の区切り文字。
  */
  "keyedit_delimiters": ".,\\\\/!?%^*;:{}=`~() ",
  /*
    キー編集の空白区切り文字。
  */
  "keyedit_delimiters_whitespace": [
    "Tab",
    "Carriage Return",
    "Line Feed"
  ],
  /*
    キー編集の移動を有効にするか。
  */
  "keyedit_move": true,
  /*
    トークンカウンターを無効にするか。
  */
  "disable_token_counters": false,
  /*
    トークンカウンターにスタイルを含めるか。
  */
  "include_styles_into_token_counters": true,
  /*
    グリッドを返すか。
  */
  "return_grid": true,
  /*
    画像を非表示にするか。
  */
  "do_not_show_images": false,
  /*
    JSモーダルライトボックスを有効にするか。
  */
  "js_modal_lightbox": true,
  /*
    JSモーダルライトボックスを初期ズームで開くか。
  */
  "js_modal_lightbox_initially_zoomed": true,
  /*
    JSモーダルライトボックスのゲームパッドを有効にするか。
  */
  "js_modal_lightbox_gamepad": false,
  /*
    JSモーダルライトボックスのゲームパッド繰り返し間隔。
  */
  "js_modal_lightbox_gamepad_repeat": 250,
  /*
    Stable Diffusion WebUIモーダルライトボックスのアイコン不透明度。
  */
  "sd_webui_modal_lightbox_icon_opacity": 1,
  /*
    Stable Diffusion WebUIモーダルライトボックスのツールバー不透明度。
  */
  "sd_webui_modal_lightbox_toolbar_opacity": 0.9,
  /*
    ギャラリーの高さ。
  */
  "gallery_height": "",
  /*
    ディレクトリを開くボタンの選択。
  */
  "open_dir_button_choice": "Subdirectory",
  /*
    高解像度ボタンをギャラリーに挿入するか。
  */
  "hires_button_gallery_insert": false,
  /*
    コンパクトなプロンプトボックスを有効にするか。
  */
  "compact_prompt_box": false,
  /*
    サンプラーをドロップダウンに表示するか。
  */
  "samplers_in_dropdown": true,
  /*
    寸法とバッチを一緒に表示するか。
  */
  "dimensions_and_batch_together": true,
  /*
    Stable Diffusionチェックポイントドロップダウンでショート名を使用するか。
  */
  "sd_checkpoint_dropdown_use_short": false,
  /*
    高解像度修正でサンプラーを表示するか。
  */
  "hires_fix_show_sampler": false,
  /*
    高解像度修正でプロンプトを表示するか。
  */
  "hires_fix_show_prompts": false,
  /*
    txt2img設定のアコーディオンを有効にするか。
  */
  "txt2img_settings_accordion": false,
  /*
    img2img設定のアコーディオンを有効にするか。
  */
  "img2img_settings_accordion": false,
  /*
    現在の処理後に中断するか。
  */
  "interrupt_after_current": true,
  /*
    ローカライゼーション設定。
  */
  "localization": "None",
  /*
    クイック設定リスト。
  */
  "quick_setting_list": [],
  /*
    UIタブの順序。
  */
  "ui_tab_order": [],
  /*
    隠しタブ。
  */
  "hidden_tabs": [],
  /*
    クイック設定バーのないタブ。
  */
  "tabs_without_quick_settings_bar": [
    "Spaces"
  ],
  /*
    UIの並べ替えリスト。
  */
  "ui_reorder_list": [],
  /*
    Gradioテーマ。
  */
  "gradio_theme": "Default",
  /*
    Gradioテーマをキャッシュするか。
  */
  "gradio_themes_cache": true,
  /*
    タイトルに進行状況を表示するか。
  */
  "show_progress_in_title": true,
  /*
    シードを送信するか。
  */
  "send_seed": true,
  /*
    サイズを送信するか。
  */
  "send_size": true,
  /*
    UIスクリプトの再読み込みを有効にするか。
  */
  "enable_reloading_ui_scripts": false,
  /*
    Infotextの説明。
  */
  "infotext_explanation": "Infotext is what this software calls the text that contains generation parameters and can be used to generate the same picture again.\\nIt is displayed in UI below the image. To use infotext, paste it into the prompt and click the ↙️ paste button.",
  /*
    PNG情報埋め込みを有効にするか。
  */
  "enable_pnginfo": true,
  /*
    ステルスPNG情報オプション。
  */
  "stealth_pnginfo_option": "Alpha",
  /*
    テキストファイルを保存するか。
  */
  "save_txt": false,
  /*
    情報にモデル名を追加するか。
  */
  "add_model_name_to_info": true,
  /*
    情報にモデルハッシュを追加するか。
  */
  "add_model_hash_to_info": true,
  /*
    情報にVAE名を追加するか。
  */
  "add_vae_name_to_info": true,
  /*
    情報にVAEハッシュを追加するか。
  */
  "add_vae_hash_to_info": true,
  /*
    情報にユーザー名を追加するか。
  */
  "add_user_name_to_info": false,
  /*
    infotextにバージョンを追加するか。
  */
  "add_version_to_infotext": true,
  /*
    ウェイトの自動スワップを無効にするか。
  */
  "disable_weights_auto_swap": true,
  /*
    infotextの貼り付けをスキップする項目。
  */
  "infotext_skip_pasting": [],
  /*
    infotextのスタイル適用条件。
  */
  "infotext_styles": "Apply if any",
  /*
    プログレスバーを表示するか。
  */
  "show_progressbar": true,
  /*
    ライブプレビューを有効にするか。
  */
  "live_previews_enable": true,
  /*
    ライブプレビューの画像形式。
  */
  "live_previews_image_format": "png",
  /*
    進行状況グリッドを表示するか。
  */
  "show_progress_grid": true,
  /*
    Nステップごとに進行状況を表示するか。
  */
  "show_progress_every_n_steps": 10,
  /*
    進行状況の表示タイプ。
  */
  "show_progress_type": "Approx NN",
  /*
    低VRAM環境でライブプレビューのフル表示を許可するか。
  */
  "live_preview_allow_lowvram_full": false,
  /*
    ライブプレビューの内容。
  */
  "live_preview_content": "Prompt",
  /*
    ライブプレビューの更新間隔（ミリ秒）。
  */
  "live_preview_refresh_period": 1000,
  /*
    ライブプレビューの高速中断を有効にするか。
  */
  "live_preview_fast_interrupt": false,
  /*
    モーダルライトボックスでJSライブプレビューを有効にするか。
  */
  "js_live_preview_in_modal_lightbox": false,
  /*
    生成中に画面のスリープを防ぐか。
  */
  "prevent_screen_sleep_during_generation": true,
  /*
    非表示にするサンプラー。
  */
  "hide_samplers": [],
  /*
    ETA DDIM。
  */
  "eta_ddim": "0",
  /*
    ETA Ancestral。
  */
  "eta_ancestral": 1,
  /*
    DDIM離散化タイプ。
  */
  "ddim_discretize": "uniform",
  /*
    S_churn値。
  */
  "s_churn": "0",
  /*
    S_tmin値。
  */
  "s_tmin": "0",
  /*
    S_tmax値。
  */
  "s_tmax": "0",
  /*
    S_noise値。
  */
  "s_noise": 1,
  /*
    シグマの最小値。
  */
  "sigma_min": "0",
  /*
    シグマの最大値。
  */
  "sigma_max": "0",
  /*
    Rho値。
  */
  "rho": "0",
  /*
    ETAノイズシードデルタ。
  */
  "eta_noise_seed_delta": "0",
  /*
    常に最後から2番目のシグマを破棄するか。
  */
  "always_discard_next_to_last_sigma": false,
  /*
    SGMノイズ乗数。
  */
  "sgm_noise_multiplier": false,
  /*
    UniPCバリアント。
  */
  "uni_pc_variant": "bh1",
  /*
    UniPCスキップタイプ。
  */
  "uni_pc_skip_type": "time_uniform",
  "uni_pc_order": 3,
  /*
    UniPCの低次最終を有効にするか。
  */
  "uni_pc_lower_order_final": true,
  /*
    Stable Diffusionノイズスケジュール。
  */
  "sd_noise_schedule": "Default",
  /*
    早期条件をスキップするか。
  */
  "skip_early_cond": "0",
  /*
    ベータ分布アルファ。
  */
  "beta_dist_alpha": 0.6,
  /*
    ベータ分布ベータ。
  */
  "beta_dist_beta": 0.6,
  /*
    メインUIで後処理を有効にする項目。
  */
  "postprocessing_enable_in_main_ui": [],
  /*
    Extrasで後処理を無効にする項目。
  */
  "postprocessing_disable_in_extras": [],
  /*
    後処理の操作順序。
  */
  "postprocessing_operation_order": [],
  /*
    キャッシュ内のアップスケール画像の最大数。
  */
  "upscaling_max_images_in_cache": 5,
  /*
    既存のキャプションの後処理アクション。
  */
  "postprocessing_existing_caption_action": "Ignore",
  /*
    無効な拡張機能。
  */
  "disabled_extensions": [],
  /*
    すべての拡張機能を無効にするか。
  */
  "disable_all_extensions": "none",
  /*
    設定状態を復元するファイル。
  */
  "restore_config_state_file": "",
  /*
    Stable Diffusionチェックポイントのハッシュ。
  */
  "sd_checkpoint_hash": "",
  /*
    Forge UNetストレージのデータ型。
  */
  "forge_unet_storage_dtype": "Automatic",
  /*
    Forge推論メモリ。
  */
  "forge_inference_memory": 1024,
  /*
    Forge非同期ロード。
  */
  "forge_async_loading": "Queue",
  /*
    Forge共有メモリをピン留めするか。
  */
  "forge_pin_shared_memory": "CPU",
  /*
    Forgeプリセット。
  */
  "forge_preset": "sd",
  /*
    Forge追加モジュール。
  */
  "forge_additional_modules": [],
  /*
    Forgeキャンバスをプレーンにするか。
  */
  "forge_canvas_plain": false,
  /*
    Forgeキャンバスツールバーを常に表示するか。
  */
  "forge_canvas_toolbar_always": false,
  /*
    プロンプトコメントを有効にするか。
  */
  "enable_prompt_comments": true,
  /*
    Stable Diffusion txt2imgの幅。
  */
  "sd_t2i_width": 512,
  /*
    Stable Diffusion txt2imgの高さ。
  */
  "sd_t2i_height": 640,
  /*
    Stable Diffusion txt2imgのCFGスケール。
  */
  "sd_t2i_cfg": 7,
  /*
    Stable Diffusion txt2imgのHR CFGスケール。
  */
  "sd_t2i_hr_cfg": 7,
  /*
    Stable Diffusion img2imgの幅。
  */
  "sd_i2i_width": 512,
  /*
    Stable Diffusion img2imgの高さ。
  */
  "sd_i2i_height": 512,
  /*
    Stable Diffusion img2imgのCFGスケール。
  */
  "sd_i2i_cfg": 7,
  /*
    XL txt2imgの幅。
  */
  "xl_t2i_width": 896,
  /*
    XL txt2imgの高さ。
  */
  "xl_t2i_height": 1152,
  /*
    XL txt2imgのCFGスケール。
  */
  "xl_t2i_cfg": 5,
  /*
    XL txt2imgのHR CFGスケール。
  */
  "xl_t2i_hr_cfg": 5,
  /*
    XL img2imgの幅。
  */
  "xl_i2i_width": 1024,
  /*
    XL img2imgの高さ。
  */
  "xl_i2i_height": 1024,
  /*
    XL img2imgのCFGスケール。
  */
  "xl_i2i_cfg": 5,
  /*
    XL GPUメモリ（MB）。
  */
  "xl_GPU_MB": 11257,
  /*
    Flux txt2imgの幅。
  */
  "flux_t2i_width": 896,
  /*
    Flux txt2imgの高さ。
  */
  "flux_t2i_height": 1152,
  /*
    Flux txt2imgのCFGスケール。
  */
  "flux_t2i_cfg": 1,
  /*
    Flux txt2imgのHR CFGスケール。
  */
  "flux_t2i_hr_cfg": 1,
  /*
    Flux txt2imgの蒸留CFGスケール。
  */
  "flux_t2i_d_cfg": 3.5,
  /*
    Flux txt2imgのHR蒸留CFGスケール。
  */
  "flux_t2i_hr_d_cfg": 3.5,
  /*
    Flux img2imgの幅。
  */
  "flux_i2i_width": 1024,
  /*
    Flux img2imgの高さ。
  */
  "flux_i2i_height": 1024,
  /*
    Flux img2imgのCFGスケール。
  */
  "flux_i2i_cfg": 1,
  /*
    Flux img2imgの蒸留CFGスケール。
  */
  "flux_i2i_d_cfg": 3.5,
  /*
    Flux GPUメモリ（MB）。
  */
  "flux_GPU_MB": 11257,
  /*
    UI内の設定の説明。
  */
  "settings_in_ui": "This page allows you to add some settings to the main interface of txt2img and img2img tabs.",
  /*
    txt2imgの追加オプション。
  */
  "extra_options_txt2img": [],
  /*
    img2imgの追加オプション。
  */
  "extra_options_img2img": [],
  /*
    追加オプションの列数。
  */
  "extra_options_cols": 1,
  /*
    追加オプションのアコーディオンを有効にするか。
  */
  "extra_options_accordion": false
}
