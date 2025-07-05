# Stable Diffusion API: `/sdapi/v1/sd-models`

## 概要
Stable Diffusionモデルの一覧を取得するためのAPIエンドポイントです。

## リクエストメソッド
`GET`

## リクエストURL
`http://127.0.0.1:7860/sdapi/v1/sd-models`

## リクエストボディ
なし

## レスポンス (200 Successful Response)
```json
[
  {
    /*
      モデルのタイトル。通常、ファイル名と短いハッシュ値が含まれます。
      例: "cyberrealisticPony_v10.safetensors [8f79fac053]"
    */
    "title": "cyberrealisticPony_v10.safetensors [8f79fac053]",
    /*
      モデルの短い名前。
      例: "cyberrealisticPony_v10"
    */
    "model_name": "cyberrealisticPony_v10",
    /*
      モデルの短いハッシュ値。
    */
    "hash": "8f79fac053",
    /*
      モデルのSHA256ハッシュ値。
    */
    "sha256": "8f79fac0532cdf82d04be29bb0ef33cc2a8d8262fad06ca4e987c89a1ec0fa9a",
    /*
      モデルのファイルパス。
      例: "E:\\webui\\models\\Stable-diffusion\\cyberrealisticPony_v10.safetensors"
    */
    "filename": "E:\\webui\\models\\Stable-diffusion\\cyberrealisticPony_v10.safetensors",
    /*
      モデルの設定。
      通常はnullまたは空の文字列です。
    */
    "config": null
  },
  {
    /*
      モデルのタイトル。通常、ファイル名と短いハッシュ値が含まれます。
      例: "waiNSFWIllustrious_v140.safetensors [bdb59bac77]"
    */
    "title": "waiNSFWIllustrious_v140.safetensors [bdb59bac77]",
    /*
      モデルの名前。
      例: "waiNSFWIllustrious_v140"
    */
    "model_name": "waiNSFWIllustrious_v140",
    /*
      モデルのハッシュ値。
    */
    "hash": "bdb59bac77",
    /*
      モデルのSHA256ハッシュ値。
    */
    "sha256": "bdb59bac77d94ae7a55ff893170f9554c3f349e48a1b73c0c17c0b7c6f4d41a2",
    /*
      モデルのファイルパス。
      例: "E:\\webui\\models\\Stable-diffusion\\waiNSFWIllustrious_v140.safetensors"
    */
    "filename": "E:\\webui\\models\\Stable-diffusion\\waiNSFWIllustrious_v140.safetensors",
    /*
      モデルの設定。
      通常はnullまたは空の文字列です。
    */
    "config": null
  }
]
