using System;
using DxLibDLL;

class Program
{
    static void Main()
    {
        // ウィンドウモードで起動するように設定
        DX.ChangeWindowMode(DX.TRUE);

        // Dxlib の初期化
        DX.DxLib_Init();
        // 描画先を裏画面に設定
        DX.SetDrawScreen(DX.DX_SCREEN_BACK);

        // メインループ
        while (DX.ProcessMessage() == 0)
        {
            // 画面をクリア
            DX.ClearDrawScreen();
            var muridegozaru = DX.LoadGraph("G5ueHv1boAAJUzV.png");
            DX.DrawGraph(0,0,muridegozaru,1);
            // 裏画面の内容を表画面に反映
            DX.ScreenFlip();
        }

        // Dxlib の終了処理
        DX.DxLib_End();
    }
}
