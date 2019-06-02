using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WhackAMole.BLL
{
    public delegate void MoleGameHandler(Game game);
    public delegate void MoleGameOverHandler(Game game);

    public class Game
    {
        SoundPlayer myPlayer = new SoundPlayer();
        public event MoleGameHandler GameStart;
        public event MoleGameOverHandler GameOver;
        public Player Player { get; set; }
        public int level { get; set; }

        public bool Level()
        {
            level = 1;
            if (Player.Score == 5)
            {
                level++;
                return true;
            }
            else if (Player.Score == 10)
            {
                level += 2;
                return true;
            }
            else if (Player.Score == 15)
            {
                level += 3;
                return true;
            }
            return false;
        }

        public Game()
        {
            Player = new Player("Player");
        }

        public void StartGame()
        {
            GameStart(this);
        }

        public void GameIsOver()
        {
            PlayMusic();
            GameOver(this);
        }

        public void PlayMusic()
        {
            myPlayer.Stream = Properties.Resources.cs;
            myPlayer.Play();
        }

        public void StopMusic()
        {
            myPlayer.Stop();
        }
    }
}
