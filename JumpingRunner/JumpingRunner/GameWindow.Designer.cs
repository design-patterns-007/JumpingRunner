using System.Drawing;

namespace JumpingRunner
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PictureBoxGame = new System.Windows.Forms.PictureBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.ComboBoxLevel = new System.Windows.Forms.ComboBox();
            this.LabelPlayerEquipment = new System.Windows.Forms.Label();
            this.CheckBoxHat = new System.Windows.Forms.CheckBox();
            this.CheckBoxSunGlasses = new System.Windows.Forms.CheckBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ComboBoxBackground = new System.Windows.Forms.ComboBox();
            this.BackgroundLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGame)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxGame
            // 
            this.PictureBoxGame.Location = new System.Drawing.Point(11, 79);
            this.PictureBoxGame.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxGame.Name = "PictureBoxGame";
            this.PictureBoxGame.Size = new System.Drawing.Size(859, 378);
            this.PictureBoxGame.TabIndex = 0;
            this.PictureBoxGame.TabStop = false;
            this.PictureBoxGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxGame_Paint);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(5, 47);
            this.LevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(80, 17);
            this.LevelLabel.TabIndex = 1;
            this.LevelLabel.Text = "Select level";
            // 
            // ComboBoxLevel
            // 
            this.ComboBoxLevel.FormattingEnabled = true;
            this.ComboBoxLevel.Location = new System.Drawing.Point(93, 44);
            this.ComboBoxLevel.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxLevel.Name = "ComboBoxLevel";
            this.ComboBoxLevel.Size = new System.Drawing.Size(97, 24);
            this.ComboBoxLevel.TabIndex = 2;
            // 
            // LabelPlayerEquipment
            // 
            this.LabelPlayerEquipment.AutoSize = true;
            this.LabelPlayerEquipment.Location = new System.Drawing.Point(461, 47);
            this.LabelPlayerEquipment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPlayerEquipment.Name = "LabelPlayerEquipment";
            this.LabelPlayerEquipment.Size = new System.Drawing.Size(118, 17);
            this.LabelPlayerEquipment.TabIndex = 3;
            this.LabelPlayerEquipment.Text = "Player equipment";
            // 
            // CheckBoxHat
            // 
            this.CheckBoxHat.AutoSize = true;
            this.CheckBoxHat.Location = new System.Drawing.Point(588, 47);
            this.CheckBoxHat.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxHat.Name = "CheckBoxHat";
            this.CheckBoxHat.Size = new System.Drawing.Size(52, 21);
            this.CheckBoxHat.TabIndex = 4;
            this.CheckBoxHat.Text = "Hat";
            this.CheckBoxHat.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSunGlasses
            // 
            this.CheckBoxSunGlasses.AutoSize = true;
            this.CheckBoxSunGlasses.Location = new System.Drawing.Point(648, 46);
            this.CheckBoxSunGlasses.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxSunGlasses.Name = "CheckBoxSunGlasses";
            this.CheckBoxSunGlasses.Size = new System.Drawing.Size(103, 21);
            this.CheckBoxSunGlasses.TabIndex = 5;
            this.CheckBoxSunGlasses.Text = "Sunglasses";
            this.CheckBoxSunGlasses.UseVisualStyleBackColor = true;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(768, 43);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(100, 28);
            this.ButtonStart.TabIndex = 6;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ComboBoxBackground
            // 
            this.ComboBoxBackground.FormattingEnabled = true;
            this.ComboBoxBackground.Location = new System.Drawing.Point(348, 42);
            this.ComboBoxBackground.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxBackground.Name = "ComboBoxBackground";
            this.ComboBoxBackground.Size = new System.Drawing.Size(97, 24);
            this.ComboBoxBackground.TabIndex = 8;
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.AutoSize = true;
            this.BackgroundLabel.Location = new System.Drawing.Point(213, 46);
            this.BackgroundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(126, 17);
            this.BackgroundLabel.TabIndex = 7;
            this.BackgroundLabel.Text = "Select background";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time passed:";
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Location = new System.Drawing.Point(452, 9);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(24, 17);
            this.sec.TabIndex = 10;
            this.sec.Text = "00";
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Location = new System.Drawing.Point(493, 9);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(24, 17);
            this.ms.TabIndex = 11;
            this.ms.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "ms";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxBackground);
            this.Controls.Add(this.BackgroundLabel);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.CheckBoxSunGlasses);
            this.Controls.Add(this.CheckBoxHat);
            this.Controls.Add(this.LabelPlayerEquipment);
            this.Controls.Add(this.ComboBoxLevel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.PictureBoxGame);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameWindow";
            this.Text = "JumpingRunner";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameWindow_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxGame;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.ComboBox ComboBoxLevel;
        private System.Windows.Forms.Label LabelPlayerEquipment;
        private System.Windows.Forms.CheckBox CheckBoxHat;
        private System.Windows.Forms.CheckBox CheckBoxSunGlasses;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ComboBox ComboBoxBackground;
        private System.Windows.Forms.Label BackgroundLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sec;
        private System.Windows.Forms.Label ms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

