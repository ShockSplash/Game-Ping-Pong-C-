namespace PingPong1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Background = new System.Windows.Forms.Panel();
            this.Unpause = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.MessageRestart = new System.Windows.Forms.Label();
            this.LoseLabel = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.GameBall = new System.Windows.Forms.PictureBox();
            this.GamePanel = new System.Windows.Forms.PictureBox();
            this.Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Background.Controls.Add(this.Unpause);
            this.Background.Controls.Add(this.pause);
            this.Background.Controls.Add(this.Start);
            this.Background.Controls.Add(this.MessageRestart);
            this.Background.Controls.Add(this.LoseLabel);
            this.Background.Controls.Add(this.Result);
            this.Background.Controls.Add(this.GameBall);
            this.Background.Controls.Add(this.GamePanel);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1280, 504);
            this.Background.TabIndex = 0;
            // 
            // Unpause
            // 
            this.Unpause.AutoSize = true;
            this.Unpause.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unpause.Location = new System.Drawing.Point(713, 295);
            this.Unpause.Name = "Unpause";
            this.Unpause.Size = new System.Drawing.Size(617, 79);
            this.Unpause.TabIndex = 7;
            this.Unpause.Text = "Press P to unpause!";
            // 
            // pause
            // 
            this.pause.AutoSize = true;
            this.pause.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.Location = new System.Drawing.Point(22, 52);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(251, 25);
            this.pause.TabIndex = 6;
            this.pause.Text = "Press G to pause Game!";
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(240, 197);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(1145, 105);
            this.Start.TabIndex = 5;
            this.Start.Text = "Press F5 to start the game!";
            // 
            // MessageRestart
            // 
            this.MessageRestart.AutoSize = true;
            this.MessageRestart.Font = new System.Drawing.Font("MV Boli", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageRestart.Location = new System.Drawing.Point(272, 239);
            this.MessageRestart.Name = "MessageRestart";
            this.MessageRestart.Size = new System.Drawing.Size(573, 56);
            this.MessageRestart.TabIndex = 4;
            this.MessageRestart.Text = "For restart press \"Enter\"!";
            // 
            // LoseLabel
            // 
            this.LoseLabel.AutoSize = true;
            this.LoseLabel.Font = new System.Drawing.Font("MV Boli", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoseLabel.Location = new System.Drawing.Point(418, 77);
            this.LoseLabel.Name = "LoseLabel";
            this.LoseLabel.Size = new System.Drawing.Size(482, 120);
            this.LoseLabel.TabIndex = 3;
            this.LoseLabel.Text = "You Lose!";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("MV Boli", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(3, 9);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(133, 39);
            this.Result.TabIndex = 2;
            this.Result.Text = "Score: 0";
            this.Result.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameBall
            // 
            this.GameBall.BackColor = System.Drawing.Color.RoyalBlue;
            this.GameBall.ErrorImage = null;
            this.GameBall.Location = new System.Drawing.Point(253, 119);
            this.GameBall.Name = "GameBall";
            this.GameBall.Size = new System.Drawing.Size(40, 40);
            this.GameBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GameBall.TabIndex = 1;
            this.GameBall.TabStop = false;
            this.GameBall.Click += new System.EventHandler(this.GameBall_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Maroon;
            this.GamePanel.Location = new System.Drawing.Point(253, 410);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(229, 28);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.TabStop = false;
            this.GamePanel.Click += new System.EventHandler(this.GamePanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1280, 504);
            this.Controls.Add(this.Background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.PictureBox GamePanel;
        private System.Windows.Forms.PictureBox GameBall;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label LoseLabel;
        private System.Windows.Forms.Label MessageRestart;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label pause;
        private System.Windows.Forms.Label Unpause;
    }
}

