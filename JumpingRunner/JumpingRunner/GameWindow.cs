using JumpingRunner.Obstacles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JumpingRunner.Difficulties;
using System.Diagnostics;

namespace JumpingRunner
{
    public partial class GameWindow : Form
    {
        public Game Game { get; set; }
        private int Seconds;
        private int Milliseconds;

        public GameWindow()
        {
            InitializeComponent();
            Settings.PictureBoxHeight = PictureBoxGame.Height;
            Settings.PictureBoxWidth = PictureBoxGame.Width;
            Settings.PictureBoxGroundHeight = Settings.PictureBoxHeight - 30;

            InitializeComboboxes();
            InitializeGame();
        }

        private void InitializeComboboxes()
        {
            ComboBoxBackground.Items.Add("Ice");
            ComboBoxBackground.Items.Add("Desert");
            ComboBoxBackground.Items.Add("Jungle");
            ComboBoxBackground.SelectedIndex = 0;
            ComboBoxBackground.DropDownStyle = ComboBoxStyle.DropDownList;

            ComboBoxLevel.Items.Add("Easy");
            ComboBoxLevel.Items.Add("Hard");
            ComboBoxLevel.Items.Add("Impossible");
            ComboBoxLevel.SelectedIndex = 0;
            ComboBoxLevel.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitializeGame()
        {
            Player player = new BasicPlayer(new Rectangle(100, 200, 30, 30), Color.Red);
            //set hats if any
            if (CheckBoxHat.Checked) {
                player = new PlayerHatDecorator(player);
                Console.WriteLine("x");
            }
            if (CheckBoxSunGlasses.Checked) {
                player = new PlayerSunglassesDecorator(player);
            }

            IBackgroundBuilder backgroundBuilder = new BackgroundBuilder();
            BackgroundBuildDirector backgroundBuildDirector = new BackgroundBuildDirector(backgroundBuilder);

            //set the background
            if ((string) ComboBoxBackground.SelectedItem == "Ice") {
                backgroundBuildDirector.Construct(EStageStyle.ICE);
            } else if ((string) ComboBoxBackground.SelectedItem == "Desert") {
                backgroundBuildDirector.Construct(EStageStyle.DESERT);
            }else if((string) ComboBoxBackground.SelectedItem == "Jungle") {
                backgroundBuildDirector.Construct(EStageStyle.JUNGLE);
            }
            Background background = backgroundBuildDirector.GetBackground();
            string difficultySelected = (string)ComboBoxLevel.SelectedItem;

            IDifficulty difficulty=null;

            //set the difficulty
            if (difficultySelected == "Easy") {
                difficulty = new EasyDifficulty();
            } else if (difficultySelected == "Hard") {
                difficulty = new HardDifficulty();
            } else if (difficultySelected == "Impossible") {
                difficulty = new ImposibleDifficulty();
            }

            Game = new Game(player, background,difficulty);
            
        }

        private void ShowTime()
        {
            sec.Text = Seconds.ToString(); 
            ms.Text = Milliseconds.ToString(); 
        }
        private void IncreaseMilliseconds()
        {
            if(Milliseconds == 59)
            {
                Milliseconds = 0;
                Seconds++;
            }
            else
            {
                Milliseconds++;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!Game.IsGameOver) {
                IncreaseMilliseconds();
                ShowTime();
                PictureBoxGame.Invalidate();
                Game.Update();
            }
            else
            {
                ShowTime();
            }
        }

        private void PictureBoxGame_Paint(object sender, PaintEventArgs e)
        {
            Game.Paint(sender, e);
        }

        private void GameWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w') {
                Game.Player.StartJump();
            }
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {            
            Game.Player.EndJump();
        }
        
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Seconds = 0;
            Milliseconds = 0;

            InitializeGame();
            Timer.Start();           
        }

        private void SetWindowEnable(bool enabled)
        {
            ComboBoxBackground.Enabled = enabled;
            ComboBoxLevel.Enabled = enabled;
            CheckBoxHat.Enabled = enabled;
            CheckBoxSunGlasses.Enabled = enabled;
            ButtonStart.Enabled = enabled;
        }
        
    }
}
