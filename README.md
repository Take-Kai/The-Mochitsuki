
# THE 餅つき
小学生を対象とした，餅つきを体験できるエンタテイメントシステム．

八戸高専4年次の知能情報実験にて制作．

ピコピコハンマーにボタンを取り付けた杵と，ダンボールで成形し表面にボタンを取り付けた臼から送られる信号をArduinoからUnityへと送信し，餅つき動作を判定．

詳細な技術解説・動作画面などは[Notionページ](https://wholesale-beginner-8e9.notion.site/Portfolio-342306a87b498080903ac7872b637bb8?p=347306a87b49801b9d00ddbc96f5aca3&pm=c)にまとめています．

---

## ⚒️ 開発環境
- **Unity**：餅つき動作の判定，アニメーション
- **Arduino**：杵・臼のボタン入力検知，シリアル通信（送信データ：杵="K"，臼="U"）
- **Hardware**：自作の杵（ピコピコハンマーにボタン取り付け），臼（ダンボールで作成）

## 📁 ソースコードの索引
コードの役割ごとに分類しています．

### 1. ハードウェア制御（Arduino）
- [`arduino_unity_test.ino`](./arduino_unity_test.ino)
  - 杵と臼の入力検知．Unityとのシリアル通信．
 
### 2. ソフトウェア（Unity / Scripts）
Unity側の処理は以下のファイルにまとめています．

| スクリプト | 役割 |
| :--- | :---|
| [`ChangeOrder.cs`](./TheMochitsuki/Assets/Scripts/ChangeOrder.cs) | 画像やオブジェクトの重なりを調整 |
|


## 開発環境
Unity, Arduino
