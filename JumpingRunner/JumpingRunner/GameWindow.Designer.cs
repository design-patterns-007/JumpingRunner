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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGame)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxGame
            // 
            this.PictureBoxGame.Location = new System.Drawing.Point(11, 111);
            this.PictureBoxGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBoxGame.Name = "PictureBoxGame";
            this.PictureBoxGame.Size = new System.Drawing.Size(859, 346);
            this.PictureBoxGame.TabIndex = 0;
            this.PictureBoxGame.TabStop = false;
            this.PictureBoxGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxGame_Paint);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(35, 38);
            this.LevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(80, 17);
            this.LevelLabel.TabIndex = 1;
            this.LevelLabel.Text = "Select level";
            // 
            // ComboBoxLevel
            // 
            this.ComboBoxLevel.FormattingEnabled = true;
            this.ComboBoxLevel.Location = new System.Drawing.Point(144, 41);
            this.ComboBoxLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxLevel.Name = "ComboBoxLevel";
            this.ComboBoxLevel.Size = new System.Drawing.Size(97, 24);
            this.ComboBoxLevel.TabIndex = 2;
            // 
            // LabelPlayerEquipment
            // 
            this.LabelPlayerEquipment.AutoSize = true;
            this.LabelPlayerEquipment.Location = new System.Drawing.Point(313, 43);
            this.LabelPlayerEquipment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPlayerEquipment.Name = "LabelPlayerEquipment";
            this.LabelPlayerEquipment.Size = new System.Drawing.Size(118, 17);
            this.LabelPlayerEquipment.TabIndex = 3;
            this.LabelPlayerEquipment.Text = "Player equipment";
            // 
            // CheckBoxHat
            // 
            this.CheckBoxHat.AutoSize = true;
            this.CheckBoxHat.Location = new System.Drawing.Point(439, 43);
            this.CheckBoxHat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBoxHat.Name = "CheckBoxHat";
            this.CheckBoxHat.Size = new System.Drawing.Size(52, 21);
            this.CheckBoxHat.TabIndex = 4;
            this.CheckBoxHat.Text = "Hat";
            this.CheckBoxHat.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSunGlasses
            // 
            this.CheckBoxSunGlasses.AutoSize = true;
            this.CheckBoxSunGlasses.Location = new System.Drawing.Point(504, 42);
            this.CheckBoxSunGlasses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckBoxSunGlasses.Name = "CheckBoxSunGlasses";
            this.CheckBoxSunGlasses.Size = new System.Drawing.Size(103, 21);
            this.CheckBoxSunGlasses.TabIndex = 5;
            this.CheckBoxSunGlasses.Text = "Sunglasses";
            this.CheckBoxSunGlasses.UseVisualStyleBackColor = true;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(709, 43);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(100, 28);
            this.ButtonStart.TabIndex = 6;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.Timer.Interval = 16;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 470);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.CheckBoxSunGlasses);
            this.Controls.Add(this.CheckBoxHat);
            this.Controls.Add(this.LabelPlayerEquipment);
            this.Controls.Add(this.ComboBoxLevel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.PictureBoxGame);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameWindow";
            this.Text = "Form1";
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
    }
}

