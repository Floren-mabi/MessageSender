# MessageSender
Plugin_Kuji用発声リクエスト送信コマンドラインツール

#### 使用方法
1. [MessageSender.exe をダウンロード](https://github.com/Floren-mabi/MessageSender/releases)し、LimeChat2のインストールディレクトリへ配置
2. [Plugin_Kuji.dll をダウンロード](https://github.com/Floren-mabi/Plugin_Kuji/releases)し、棒読みちゃんのインストールディレクトリへ配置
3. LimeChat2を起動し、メニューの\[設定\]→\[マクロの設定\]をクリックし、マクロの設定画面を開く
4. \[新規\]ボタンをクリックし、マクロ名を入力(任意の名前)し、OKボタンをクリックする
5. マクロファイルの編集画面が開くので、\[新規\]ボタンをクリックする
6. マクロ項目の編集画面で以下の設定内容を入力し、OKボタンをクリックする
 * ユーザ : %me|*
 * コマンド : Privmsg
 * 自分の状態 : なし
 * 送信者の状態 : なし
 * 動作 : ExecuteMinimize
 * 動作の情報 : "MessageSender.exe" "%m"
7. マクロの設定画面で、作成したマクロの名前の行のメッセージキャプチャ対象のチャンネルの列を右クリックして「○」を付ける
8. 棒読みちゃんを起動し、\[その他\]タブの「くじプラグイン」にチェックを入れる  
  
以上
