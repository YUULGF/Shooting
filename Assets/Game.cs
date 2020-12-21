using GameCanvas;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

/// <summary>
/// ゲームクラス。
/// </summary>
public sealed class Game : GameBase
{
    // 変数の宣言
    float player_x;
    float player_y;
    float player_speed;
    const int ENEMY_NUM = 10;
    int[] enemy_x = new int [ENEMY_NUM];
    int[] enemy_y = new int [ENEMY_NUM];
    int[] enemy_col = new int [ENEMY_NUM];
    int[] enemy_speed = new int [ENEMY_NUM];
    GcImage player_img = GcImage.GR0;
    GcImage[] enemy_img = new GcImage [ENEMY_NUM];
    GcImage[] bullet_img = new GcImage[BULLET_NUM];
    bool[] enemy_alive_flag = new bool [ENEMY_NUM];
    bool[] bullet_alive_flag = new bool[BULLET_NUM];
    int score;
    int player_w = 32;
    int player_h = 32;
    int enemy_w = 24;
    int enemy_h = 24;

    const int BULLET_NUM = 10;
    int next_bullet;
    float[] bullet_x = new float [BULLET_NUM];
    float[] bullet_y = new float [BULLET_NUM];
    float bullet_count;
    float bullet_speed;

    int gameState = 0;


    /// <summary>
    /// 初期化処理
    /// </summary>
    public override void InitGame()
    {
        // キャンバスの大きさを設定します
        gc.ChangeCanvasSize(720, 1280);

        resetGame();
        
    }

    /// <summary>
    /// 動きなどの更新処理
    /// </summary>
    public override void UpdateGame()
    {
        if(gameState == 0)
        {
            // タイトル画面の処理
            if(gc.GetPointerFrameCount(0) == 1)
            {
                gameState = 1;
            }
        }
        else if(gameState == 1)
        {
            // ゲーム中の処理
            for (int i = 0; i < ENEMY_NUM; i++)
            {
                enemy_y[i] = enemy_y[i] + enemy_speed[i];
                if (enemy_y[i] > 1280)
                {
                    resetEnemy(i);
                }
            }

            //弾の移動処理
            for (int k = 0; k < BULLET_NUM; k++)
            {
                bullet_y[k] -= bullet_speed;
            }

            //自機の移動処理
            if (gc.AccelerationLastX >= 0)
            {
                player_x += gc.AccelerationLastX * player_speed;
                player_img = GcImage.GR0;
            }
            else
            {
                player_x += gc.AccelerationLastX * player_speed;
                player_img = GcImage.GL0;
            }
            if (gc.AccelerationLastY > 0)
            {
                player_y += gc.AccelerationLastY * player_speed;
            }
            else
            {
                player_y += gc.AccelerationLastY * player_speed;
                bullet_count--;
            }

            //弾の発射処理
            if (gc.AccelerationLastY < -0.1)
            {
                if (bullet_count <= 0)
                {
                    resetBullet(next_bullet);
                    gc.PlaySound(GcSound.Click2);
                    next_bullet++;
                    bullet_count = 30;

                    if (next_bullet > 6)
                    {
                        next_bullet = 0;
                    }
                }
            }

            //敵と弾の当たり判定
            for (int i = 0; i < ENEMY_NUM; i++)
            {
                for(int j = 0; j < BULLET_NUM; j++)
                {
                    if (gc.CheckHitRect(enemy_x[i], enemy_y[i], enemy_w, enemy_h, bullet_x[j], bullet_y[j], 12, 24))
                    {
                        if (bullet_alive_flag[j])
                        {
                            enemy_alive_flag[i] = false;
                            bullet_alive_flag[j] = false;
                            score += enemy_col[i];
                            resetEnemy(i);
                        }
                    }
                }
                
            }
            
            //敵と自機の当たり判定
            for (int i = 0; i < ENEMY_NUM; i++)
            {
                if (gc.CheckHitRect(enemy_x[i], enemy_y[i], enemy_w, enemy_h, player_x, player_y, player_w, player_h))
                {
                    if(enemy_alive_flag[i])
                    {
                        gameState = 2;
                    }
                }
            }

        }
        else if(gameState == 2)
        {
            //結果画面の処理
            if(gc.GetPointerFrameCount(0) > 120.0f)
            {
                gameState = 0;
                resetGame();
            }
        }
        
    }

    /// <summary>
    /// 描画の処理
    /// </summary>
    public override void DrawGame()
    {
        // 画面を白で塗りつぶします
        gc.ClearScreen();

        if (gameState == 0)
        {
            //タイトル画面の描画
            gc.SetColor(0, 0, 0);
            gc.SetFontSize(48);
            gc.DrawString("Shooting!!", 240, 240);
            gc.DrawString("タップしてゲームスタート！", 60, 1000);

            gc.SetFontSize(36);
            gc.DrawString("・前に傾けると弾が発射されるよ！", 80, 400);
            gc.DrawString("・敵に当たらないように", 140, 440);
            gc.DrawString("携帯を傾けて避けよう！", 160, 480);
        }

        if(gameState == 1)
        {
            // ゲーム中の描画
            //自機の描画
            gc.DrawImage(player_img, player_x, player_y);

            //敵の描画
            for (int i = 0; i < ENEMY_NUM; i++)
            {
                if (enemy_alive_flag[i])
                {
                    gc.DrawImage(enemy_img[i], enemy_x[i], enemy_y[i]);
                }
            }

            //弾の描画
            for (int j = 0; j < BULLET_NUM; j++)
            {
                if(bullet_alive_flag[j])
                {
                    gc.DrawImage(bullet_img[j], bullet_x[j], bullet_y[j]);
                }
            }

            // 黒の文字を描画します
            gc.SetColor(0, 0, 0);
            gc.SetFontSize(36);
            //gc.DrawString("AcceX:" + gc.AccelerationLastX, 0, 0);
            //gc.DrawString("AcceY:" + gc.AccelerationLastY, 0, 0);
            gc.DrawString("傾き:" + -gc.AccelerationLastY, 0, 20);
            //gc.DrawString("AcceZ:" + gc.AccelerationLastZ, 0, 80);
            gc.DrawString("SCORE:" + score, 0, 60);
        }

        if(gameState == 2)
        {
            //ゲームオーバー画面の描画
            gc.SetFontSize(36);
            gc.DrawString("Your Score:" + score, 280, 640);
            gc.DrawString("長押しでスタート画面へ", 220, 1000);
        }
    }

    //敵の初期化関数
    void resetEnemy(int id)
    {
        enemy_x[id] = gc.Random(0, 720 - 40);
        enemy_y[id] = -gc.Random(24, 1280 - 40);
        enemy_col[id] = gc.Random(1, 3);
        enemy_speed[id] = gc.Random(6, 10);
        if(enemy_col[id] == 1)
        {
            enemy_img[id] = GcImage.BallYellow;
        }
        else if(enemy_col[id] == 2)
        {
            enemy_img[id] = GcImage.BallRed;
        }
        else
        {
            enemy_img[id] = GcImage.BallBlue;
        }

        enemy_alive_flag[id] = true;
    }

    //弾の初期化関数
    void resetBullet(int num)
    {
        bullet_x[num] = player_x;
        bullet_y[num] = player_y;
        bullet_alive_flag[num] = true;
    }

    //ゲームの初期化関数
    void resetGame()
    {
        player_x = 360;
        player_y = 1160;
        player_speed = 10.0f;

        next_bullet = 0;
        bullet_count = 30;
        bullet_speed = 10.0f;

        score = 0;

        for (int i = 0; i < ENEMY_NUM; i++)
        {
            resetEnemy(i);
        }

        for (int i = 0; i < BULLET_NUM; i++)
        {
            bullet_img[i] = GcImage.Bullet0;
            bullet_alive_flag[i] = true;
        }
    }


}
