# OcrTestCSharp

Windows11環境でC#でOCRをするための覚書

## 環境

- OS：Windows 11
  - バージョン10.0.26100.2161

## 手順

1. Windows 11 SDKのインストール
    - Visual Studio Installerからインストールできる
2. プロジェクトの作成
    - ターゲットフレームワークは.NET 8.0にする
3. プロジェクトのプロパティの設定
    1. プロジェクトを右クリックしてプロパティを開く
    2. ターゲットOSをWindowsにする
    3. ターゲットOSバージョンを1.でインストールしたSDKのバージョンに合わせる

## TODO

Windows App SDKにMicrosoft.Windows.Vision名前空間があり、より高速で正確な文字認識ができるらしい？
