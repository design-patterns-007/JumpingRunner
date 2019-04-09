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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGame)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxGame
            // 
            this.PictureBoxGame.Location = new System.Drawing.Point(8, 64);
            this.PictureBoxGame.Name = "PictureBoxGame";
            this.PictureBoxGame.Size = new System.Drawing.Size(644, 307);
            this.PictureBoxGame.TabIndex = 0;
            this.PictureBoxGame.TabStop = false;
            this.PictureBoxGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxGame_Paint);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(4, 38);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(62, 13);
            this.LevelLabel.TabIndex = 1;
            this.LevelLabel.Text = "Select level";
            // 
            // ComboBoxLevel
            // 
            this.ComboBoxLevel.FormattingEnabled = true;
            this.ComboBoxLevel.Location = new System.Drawing.Point(70, 36);
            this.ComboBoxLevel.Name = "ComboBoxLevel";
            this.ComboBoxLevel.Size = new System.Drawing.Size(74, 21);
            this.ComboBoxLevel.TabIndex = 2;
            // 
            // LabelPlayerEquipment
            // 
            this.LabelPlayerEquipment.AutoSize = true;
            this.LabelPlayerEquipment.Location = new System.Drawing.Point(346, 38);
            this.LabelPlayerEquipment.Name = "LabelPlayerEquipment";
            this.LabelPlayerEquipment.Size = new System.Drawing.Size(88, 13);
            this.LabelPlayerEquipment.TabIndex = 3;
            this.LabelPlayerEquipment.Text = "Player equipment";
            // 
            // CheckBoxHat
            // 
            this.CheckBoxHat.AutoSize = true;
            this.CheckBoxHat.Location = new System.Drawing.Point(441, 38);
            this.CheckBoxHat.Name = "CheckBoxHat";
            this.CheckBoxHat.Size = new System.Drawing.Size(43, 17);
            this.CheckBoxHat.TabIndex = 4;
            this.CheckBoxHat.Text = "Hat";
            this.CheckBoxHat.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSunGlasses
            // 
            this.CheckBoxSunGlasses.AutoSize = true;
            this.CheckBoxSunGlasses.Location = new System.Drawing.Point(486, 37);
            this.CheckBoxSunGlasses.Name = "CheckBoxSunGlasses";
            this.CheckBoxSunGlasses.Size = new System.Drawing.Size(80, 17);
            this.CheckBoxSunGlasses.TabIndex = 5;
            this.CheckBoxSunGlasses.Text = "Sunglasses";
            this.CheckBoxSunGlasses.UseVisualStyleBackColor = true;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(576, 35);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
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
            this.ComboBoxBackground.Location = new System.Drawing.Point(261, 34);
            this.ComboBoxBackground.Name = "ComboBoxBackground";
            this.ComboBoxBackground.Size = new System.Drawing.Size(74, 21);
            this.ComboBoxBackground.TabIndex = 8;
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.AutoSize = true;
            this.BackgroundLabel.Location = new System.Drawing.Point(160, 37);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(97, 13);
            this.BackgroundLabel.TabIndex = 7;
            this.BackgroundLabel.Text = "Select background";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 382);
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
    }
}

