using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhackAMole.BLL;

namespace WhackAMole.UI
{
    public partial class MoleGameForm : Form
    {
        private Game moleGame;
        private PictureBox openButton;

        public MoleGameForm()
        {
            InitializeComponent();
        }

        private void game_Start(Game game)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox btn = new PictureBox();
                    btn.Size = new Size(100, 100);
                    btn.Location = new Point(105 * j + 10, 105 * i + 10);
                    btn.Tag = 4 * i + j;
                    btn.Image = Properties.Resources.bg;
                    btn.Enabled = false;
                    btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    btn.Name = $"btn{i * 4 + j + 1}";
                    btn.Click += new EventHandler(Btn_Click);
                    this.grp_Game.Controls.Add(btn);
                }
            }
            moleGame.Player.ResetScore();
            lbl_Player.Text = moleGame.Player.Name + " " + "Score: " + moleGame.Player.Score;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            moleGame = new Game();
            moleGame.GameStart += new MoleGameHandler(game_Start);
            moleGame.GameOver += new MoleGameOverHandler(game_Over);
            moleGame.StartGame();
            tmr_Game.Interval = 30000;
            tmr_Game.Start();
            tmr_Open.Start();
            btn_Start.Enabled = false;
        }

        private void Btn_Click(object sender,EventArgs e)
        {
            var btn = sender as PictureBox;
            btn.Image = Properties.Resources.deadguy;
            moleGame.Player.HitaMole();
            lbl_Player.Text = moleGame.Player.Name + " " + "Score: " + moleGame.Player.Score;
        }

        private void game_Over(Game game)
        {
            tmr_Game.Stop();
            moleGame.StopMusic();
            var result = MessageBox.Show($"Game over. Score ={moleGame.Player.Score}", "Do you want to play again", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                btn_Start.Enabled = true;
                RestartGame();
            }
            else if (result == DialogResult.No)
            {
                Environment.Exit(1);
            }
        }

        private void RandomButton()
        {
            if (moleGame.Level())
            {
                tmr_Open.Interval = 2500 / moleGame.level;
            }
            else
            {
                tmr_Open.Interval = 2000;
            }
            tmr_Open.Tick += (sender, args) =>
             {
                 Random rnd = new Random();
                 var rndButton = rnd.Next(0, 17);
                 for (int i = 0; i <= 16; i++)
                 {
                     if (Convert.ToInt32(grp_Game.Controls[$"btn{i}"].Tag) == rndButton)
                     {
                         openButton = (PictureBox)grp_Game.Controls[$"btn{i}"];
                         openButton.Enabled = true;
                         openButton.Image = Properties.Resources.tguy;
                     }
                 }
                 if (openButton != null)
                 {
                     if (moleGame.Level())
                     {
                         tmr_Close.Interval = 2500 / moleGame.level;
                     }
                     else
                     {
                         tmr_Close.Interval = 2000;
                     }
                     tmr_Close.Start();
                 }
             };
            //tmr_Open.Interval = 2000;
            //Random rnd = new Random();
            //var rndButton = rnd.Next(0, 17);
            //for (int i = 0; i <= 16; i++)
            //{
            //    if(Convert.ToInt32(grp_Game.Controls[$"btn{i}"].Tag) == rndButton)
            //    {
            //        openButton = (PictureBox)grp_Game.Controls[$"btn{i}"];
            //        openButton.Enabled = true;
            //        openButton.Image = Properties.Resources.tguy;
            //    }
            //}
            //tmr_Close.Start();
        }

        private void RestartGame()
        {
            grp_Game.Controls.Clear();
            game_Start(moleGame);
        }

        private void tmr_Game_Tick(object sender, EventArgs e)
        {
            tmr_Open.Stop();
            tmr_Close.Stop();
            game_Over(moleGame);
        }

        private void tmr_Open_Tick(object sender, EventArgs e)
        {
            RandomButton();
        }

        private void tmr_Close_Tick(object sender, EventArgs e)
        {
            if(openButton != null)
            {
                foreach(var item in grp_Game.Controls)
                {
                    if(item is PictureBox)
                    {
                        var btn = item as PictureBox;
                        btn.Enabled = false;
                        openButton.Image = Properties.Resources.bg;
                    }
                }
            }
        }
    }
}
