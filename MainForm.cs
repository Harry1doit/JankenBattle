using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JankenBattle
{
    public partial class MainForm : Form
    {
        private int roundCount;
        private int wonCount;
        private int lossCount;

        private PictureBox[] winLossResults;

        private LifeGage playerLifeGage;
        private LifeGage enemyLifeGage;

        //試合中かどうかを設定する
        private bool InGame
        {
            set
            {
                rockButtonPictureBox.Enabled = value;
                scissorsButtonPictureBox.Enabled = value;
                paperButtonPictureBox.Enabled = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            winLossResults = new[]
            {
                winLoss1PictureBox,
                winLoss2PictureBox,
                winLoss3PictureBox,
                winLoss4PictureBox,
            };

            playerLifeGage = new LifeGage(playerLifeProgressBar, 5);
            enemyLifeGage = new LifeGage(enemyLifeProgressBar, 5);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            //試合中
            InGame = true;

            //プレイヤーと敵の手の画像をクリアする
            playerHandPictureBox.Image = null;
            enemyHandPictureBox.Image = null;

            //勝敗表をクリアする
            foreach (var pictureBox in winLossResults)
            {
                pictureBox.Image = null;
            }

            //ゲーム開始メッセージを表示する
            MessageBox.Show("ゲームスタート!");

            //ラウンド数を初期化
            roundCount = 0;

            //勝敗数を初期化
            wonCount = 0;
            lossCount = 0;

            NextRound();
        }


        /*グーを選ぶ
          プレイヤーの手をグーにしてじゃんけんをする。*/

        private void rockButtonPictureBox_Click(object sender, EventArgs e)
        {
            //　プレイヤーの手を「グー」にする
            var playerHand = JankenHand.Rock;

            Battle(playerHand);
        }

        private void Battle(JankenHand playerHand)
        {
            //　プレイヤーの手に応じた画像をゲームエリアに表示
            playerHandPictureBox.Image = GetHandImage(playerHand);

            //敵の手をランダムに決める
            var random = new Random();
            var enemyHandValue = random.Next(0, 3);
            var enemyHand = (JankenHand)enemyHandValue;

            //敵の手に応じた画像をゲームエリアに表示する
            enemyHandPictureBox.Image = GetHandImage(enemyHand);

            //勝敗を判定する
            JankenResult jankenResult;
            if (playerHand == enemyHand)
            {
                //あいこ
                jankenResult = JankenResult.Even;
            }
            else if (
                (playerHand == JankenHand.Rock && enemyHand == JankenHand.Scissors) ||
                (playerHand == JankenHand.Scissors && enemyHand == JankenHand.Paper) ||
                (playerHand == JankenHand.Paper && enemyHand == JankenHand.Rock)
                )
            {
                //勝ち
                jankenResult = JankenResult.Win;
            }
            else
            {
                //負け
                jankenResult = JankenResult.Losing;
            }


            switch (jankenResult)
            {
                case JankenResult.Even:
                    return;
                case JankenResult.Win:
                    enemyLifeGage.Attack();
                    break;
                case JankenResult.Losing:
                    playerLifeGage.Attack();
                    break;
                default:
                    break;
            }

            //ライフが残っていればラウンドを継続する
            if (playerLifeGage.Alive && enemyLifeGage.Alive)
            {
                return;
            }

            //どちらかのライフがなくなっているのでラウンドを終了する
            if (playerLifeGage.Alive)
            {
                MessageBox.Show($"{roundCount}回戦はあなたの負けです");
                lossCount += 1;
                winLossResults[roundCount - 1].Image = Properties.Resources.circle;
            }
            if (enemyLifeGage.Alive)
            {
                MessageBox.Show($"{roundCount}回戦はあなたの負けです");
                lossCount += 1;
                winLossResults[roundCount - 1].Image = Properties.Resources.cross;
            }

            //試合終了を判定する
            if (wonCount == 3 || lossCount == 3)
            {
                MessageBox.Show("試合終了!");

                if (wonCount > lossCount)
                {
                    MessageBox.Show($"ゲームクリア！ ({wonCount} 勝　{lossCount} 敗) ");
                }
                else
                {
                    MessageBox.Show($"ゲームオーバー！ ({wonCount} 勝　{lossCount} 敗) ");
                }

                //試合中ではない
                InGame = false;

                return;
            }

            //次のラウンドに移る
          

            NextRound();
        }

        private static Image GetHandImage(JankenHand hand)
        {
            Image handImage;
            if (hand == JankenHand.Rock)
            {
                handImage = Properties.Resources.rock;
            }
            else if (hand == JankenHand.Scissors)
            {
                handImage = Properties.Resources.scissors;
            }
            else
            {
                handImage = Properties.Resources.paper;
            }

            return handImage;
        }

        private void scissorsButtonPictureBox_Click(object sender, EventArgs e)
        {
            //プレイヤーの手をチョキにする
            var playerHand = JankenHand.Scissors;

            Battle(playerHand);
        }

        private void paperButtonPictureBox_Click(object sender, EventArgs e)
        {
            //プレイヤーの手をパーにする
            var playerHand = JankenHand.Paper;

            Battle(playerHand);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //画面を初期化する
            //試合中ではない
            InGame = false;
        }

        //次のラウンドに移行する
        private void NextRound()
        {
            //ライフリセット
            playerLifeGage.ResetLife();
            enemyLifeGage.ResetLife();

            //プレイヤーと敵の手の画像をクリアする
            playerHandPictureBox.Image = null;
            enemyHandPictureBox.Image = null;

            //ラウンド数加算
            roundCount += 1;
        

            MessageBox.Show($"{roundCount}回戦");
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var aboutBox = new AboutBox())
            {
                aboutBox.ShowDialog();
            }
        }
    }
}
