﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingRunner
{
    public partial class GameWindow : Form
    {
        public Game Game { get; set; }

        public GameWindow()
        {
            InitializeComponent();
            Settings.PictureBoxHeight = PictureBoxGame.Height;
            Settings.PictureBoxWidth = PictureBoxGame.Width;
            Settings.PictureBoxGroundHeight = Settings.PictureBoxHeight - 30;

            Player player = new BasicPlayer(new Rectangle(20, 200, 30, 30), Color.FromArgb(255,0,0));
            Player decorated=new PlayerHatDecorator(player);
            Player glasses = new PlayerSunglassesDecorator(decorated);

            Game = new Game(glasses);
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            PictureBoxGame.Invalidate();
            Game.Update();
        }

        private void PictureBoxGame_Paint(object sender, PaintEventArgs e)
        {
            Game.Paint(sender, e);
        }

        private void GameWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            Game.Player.StartJump();
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            Game.Player.EndJump();
        }
    }
}
