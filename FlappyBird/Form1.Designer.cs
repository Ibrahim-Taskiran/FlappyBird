namespace FlappyBird
{
    partial class FlappyBirdForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Bird = new PictureBox();
            BoruUst = new PictureBox();
            BoruAlt = new PictureBox();
            label1 = new Label();
            Zemin = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            lblRestart = new Label();
            ((System.ComponentModel.ISupportInitialize)Bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoruUst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).BeginInit();
            SuspendLayout();
            // 
            // Bird
            // 
            Bird.BackColor = Color.Transparent;
            Bird.Image = Properties.Resources.bird;
            Bird.Location = new Point(98, 150);
            Bird.Name = "Bird";
            Bird.Size = new Size(80, 60);
            Bird.SizeMode = PictureBoxSizeMode.AutoSize;
            Bird.TabIndex = 0;
            Bird.TabStop = false;
            // 
            // BoruUst
            // 
            BoruUst.Image = Properties.Resources.pipedown;
            BoruUst.Location = new Point(586, -12);
            BoruUst.Name = "BoruUst";
            BoruUst.Size = new Size(100, 162);
            BoruUst.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruUst.TabIndex = 1;
            BoruUst.TabStop = false;
            BoruUst.Click += pictureBoxEngelÜst_Click;
            // 
            // BoruAlt
            // 
            BoruAlt.Image = Properties.Resources.pipe;
            BoruAlt.Location = new Point(586, 363);
            BoruAlt.Name = "BoruAlt";
            BoruAlt.Size = new Size(100, 252);
            BoruAlt.SizeMode = PictureBoxSizeMode.StretchImage;
            BoruAlt.TabIndex = 2;
            BoruAlt.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 47);
            label1.TabIndex = 3;
            label1.Text = "SCORE :";
            // 
            // Zemin
            // 
            Zemin.Image = Properties.Resources.ground;
            Zemin.Location = new Point(-1, 546);
            Zemin.Name = "Zemin";
            Zemin.Size = new Size(809, 69);
            Zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            Zemin.TabIndex = 4;
            Zemin.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // lblRestart
            // 
            lblRestart.AutoSize = true;
            lblRestart.BackColor = Color.OrangeRed;
            lblRestart.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblRestart.Location = new Point(183, 234);
            lblRestart.Name = "lblRestart";
            lblRestart.Size = new Size(437, 47);
            lblRestart.TabIndex = 5;
            lblRestart.Text = "Yeniden Başlamak için 'R'";
            lblRestart.Visible = false;
            // 
            // FlappyBirdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 561);
            Controls.Add(lblRestart);
            Controls.Add(Zemin);
            Controls.Add(label1);
            Controls.Add(BoruAlt);
            Controls.Add(BoruUst);
            Controls.Add(Bird);
            Name = "FlappyBirdForm";
            Text = "FlappyBird";
            Load += FlappyBirdForm_Load;
            KeyDown += game_Down;
            KeyUp += game_Up;
            ((System.ComponentModel.ISupportInitialize)Bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoruUst).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoruAlt).EndInit();
            ((System.ComponentModel.ISupportInitialize)Zemin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Bird;
        private PictureBox BoruUst;
        private PictureBox BoruAlt;
        private Label label1;
        private PictureBox Zemin;
        private System.Windows.Forms.Timer GameTimer;
        private Label lblRestart;
    }
}
