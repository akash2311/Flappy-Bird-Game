
namespace Flappy_Bird_Game
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.scoretxt = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameovertxt = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.restartbtn = new System.Windows.Forms.PictureBox();
            this.pipeTop1 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.city = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.city)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // scoretxt
            // 
            this.scoretxt.AutoSize = true;
            this.scoretxt.Font = new System.Drawing.Font("Ubuntu", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretxt.Location = new System.Drawing.Point(12, 9);
            this.scoretxt.Name = "scoretxt";
            this.scoretxt.Size = new System.Drawing.Size(144, 40);
            this.scoretxt.TabIndex = 4;
            this.scoretxt.Text = "Score : 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // gameovertxt
            // 
            this.gameovertxt.AutoSize = true;
            this.gameovertxt.Font = new System.Drawing.Font("Ubuntu", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameovertxt.ForeColor = System.Drawing.Color.Brown;
            this.gameovertxt.Location = new System.Drawing.Point(258, 132);
            this.gameovertxt.Name = "gameovertxt";
            this.gameovertxt.Size = new System.Drawing.Size(327, 60);
            this.gameovertxt.TabIndex = 7;
            this.gameovertxt.Text = "Game Over !!!";
            // 
            // logo
            // 
            this.logo.Image = global::Flappy_Bird_Game.Properties.Resources.flappy_bird_logo;
            this.logo.Location = new System.Drawing.Point(220, 102);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(401, 90);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 11;
            this.logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flappy_Bird_Game.Properties.Resources.play_game_button_png_2;
            this.pictureBox1.Location = new System.Drawing.Point(330, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // restartbtn
            // 
            this.restartbtn.Image = global::Flappy_Bird_Game.Properties.Resources.restart;
            this.restartbtn.Location = new System.Drawing.Point(292, 260);
            this.restartbtn.Name = "restartbtn";
            this.restartbtn.Size = new System.Drawing.Size(234, 60);
            this.restartbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restartbtn.TabIndex = 8;
            this.restartbtn.TabStop = false;
            this.restartbtn.Click += new System.EventHandler(this.restartbtn_Click);
            // 
            // pipeTop1
            // 
            this.pipeTop1.Image = global::Flappy_Bird_Game.Properties.Resources.pipedown;
            this.pipeTop1.Location = new System.Drawing.Point(591, -49);
            this.pipeTop1.Name = "pipeTop1";
            this.pipeTop1.Size = new System.Drawing.Size(95, 241);
            this.pipeTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop1.TabIndex = 6;
            this.pipeTop1.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-1, 486);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(803, 79);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(49, 185);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(80, 60);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = ((System.Drawing.Image)(resources.GetObject("pipebottom.Image")));
            this.pipebottom.Location = new System.Drawing.Point(411, 351);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(87, 198);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 3;
            this.pipebottom.TabStop = false;
            // 
            // city
            // 
            this.city.Image = global::Flappy_Bird_Game.Properties.Resources.city;
            this.city.Location = new System.Drawing.Point(2, 317);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(799, 169);
            this.city.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.city.TabIndex = 10;
            this.city.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.scoretxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.restartbtn);
            this.Controls.Add(this.gameovertxt);
            this.Controls.Add(this.pipeTop1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.city);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.city)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoretxt;
        private System.Windows.Forms.PictureBox pipeTop1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label gameovertxt;
        private System.Windows.Forms.PictureBox restartbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox city;
        private System.Windows.Forms.PictureBox logo;
    }
}

