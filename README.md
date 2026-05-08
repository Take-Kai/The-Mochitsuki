
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

| シーン | スクリプト | 役割 |
| :--- | :--- | :--- |
| 全体 | [`ChangeOrder.cs`](./TheMochitsuki/Assets/Scripts/ChangeOrder.cs) | 画像やオブジェクトの重なりを調整 |
| スタート | [`Blinker.cs`](./TheMochitsuki/Assets/Scripts/StartScene/Blinker.cs) | スタート画面に表示される文字の一定間隔での表示 / 非表示繰り返し |
| スタート | [`PlayStart.cs`](./TheMochitsuki/Assets/Scripts/StartScene/PlayStart.cs) | ボタンが押されたらプレイ画面へ遷移 |
| スタート | [`SerialHandler1.cs`](./TheMochitsuki/Assets/Scripts/StartScene/SerialHandler1.cs) | スタート画面でのArduinoとUnityのシリアル通信 |
| スタート | [`SerialReceive1.cs`](./TheMochitsuki/Assets/Scripts/StartScene/SerialReceive1.cs) | スタート画面でArduinoから送信されたデータによる処理　|
| プレイ | [`BGM.cs`](./TheMochitsuki/Assets/Scripts/PlayScene/BGM.cs) | 流すBGMの設定・管理 |
| プレイ | [`ClickCount.cs`](./TheMochitsuki/Assets/Scripts/PlayScene/.ClickCount.cs) | 杵のボタンが押されたことの判定（Kを受信）と臼のボタンが押されたことの判定（Uを受信）を餅つき動作1回とし，何回できたかをカウント |
| プレイ | [`TimeCounter.cs`](./TheMochitsuki/Assets/Scripts/PlayScene/.TimeCounter.cs) | 餅つき動作を行う制限時間（20秒）の設定とシーン遷移の管理 |
| プレイ | [`SerialHandler.cs`](./TheMochitsuki/Assets/Scripts/PlayScene/SerialHandler.cs) | プレイ画面でのArduinoとUnityのシリアル通信 |
| プレイ | [`SerialReceive.cs`](./TheMochitsuki/Assets/Scripts/PlayScene/SerialReceive.cs) | プレイ画面でArduinoから送信されたデータによる処理（杵と臼のボタン押下によって送信されたデータの受信） |
| リザルト | [`BackTitle.cs`](./TheMochitsuki/Assets/Scripts/ResultScene/BackTitle.cs) | ボタンを押してタイトル画面に戻る処理 |
| リザルト | [`Replay.cs`](./TheMochitsuki/Assets/Scripts/ResultScene/Replay.cs) | ボタンを押してプレイ画面に戻る処理 |
| リザルト | [`SerialHandler_Result.cs`](./TheMochitsuki/Assets/Scripts/ResultScene/SerialHandler_Result.cs) | リザルト画面でのArduinoとUnityのシリアル通信 |
| リザルト | [`SerialReceive_Result.cs`](./TheMochitsuki/Assets/Scripts/ResultScene/SerialReceive.cs) | リザルト画面でArduinoから送信されたデータによる処理 |


## 開発環境
Unity, Arduino
