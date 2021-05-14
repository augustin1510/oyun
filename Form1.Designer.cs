
namespace oyun
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.time_GameControl = new System.Windows.Forms.Timer(this.components);
            this.picturebox_top = new System.Windows.Forms.PictureBox();
            this.pictureBox_Top1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Ground = new System.Windows.Forms.PictureBox();
            this.picturebox_bird = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_bird)).BeginInit();
            this.SuspendLayout();
            // 
            // time_GameControl
            // 
            this.time_GameControl.Enabled = true;
            this.time_GameControl.Interval = 20;
            this.time_GameControl.Tick += new System.EventHandler(this.gameTimer);
            // 
            // picturebox_top
            // 
            this.picturebox_top.Image = global::oyun.Properties.Resources.toprak;
            this.picturebox_top.Location = new System.Drawing.Point(173, 310);
            this.picturebox_top.Name = "picturebox_top";
            this.picturebox_top.Size = new System.Drawing.Size(70, 154);
            this.picturebox_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_top.TabIndex = 3;
            this.picturebox_top.TabStop = false;
            // 
            // pictureBox_Top1
            // 
            this.pictureBox_Top1.Image = global::oyun.Properties.Resources.toprak;
            this.pictureBox_Top1.Location = new System.Drawing.Point(277, -1);
            this.pictureBox_Top1.Name = "pictureBox_Top1";
            this.pictureBox_Top1.Size = new System.Drawing.Size(70, 167);
            this.pictureBox_Top1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Top1.TabIndex = 2;
            this.pictureBox_Top1.TabStop = false;
            this.pictureBox_Top1.Click += new System.EventHandler(this.pictureBox_Top1_Click);
            // 
            // pictureBox_Ground
            // 
            this.pictureBox_Ground.Image = global::oyun.Properties.Resources.toprak;
            this.pictureBox_Ground.Location = new System.Drawing.Point(-9, 462);
            this.pictureBox_Ground.Name = "pictureBox_Ground";
            this.pictureBox_Ground.Size = new System.Drawing.Size(373, 50);
            this.pictureBox_Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ground.TabIndex = 1;
            this.pictureBox_Ground.TabStop = false;
            this.pictureBox_Ground.Click += new System.EventHandler(this.pictureBox_Ground_Click);
            // 
            // picturebox_bird
            // 
            this.picturebox_bird.BackgroundImage = global::oyun.Properties.Resources.oyun_2;
            this.picturebox_bird.Image = global::oyun.Properties.Resources.oyun3;
            this.picturebox_bird.Location = new System.Drawing.Point(21, 224);
            this.picturebox_bird.Name = "picturebox_bird";
            this.picturebox_bird.Size = new System.Drawing.Size(42, 51);
            this.picturebox_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_bird.TabIndex = 0;
            this.picturebox_bird.TabStop = false;
            this.picturebox_bird.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(359, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturebox_top);
            this.Controls.Add(this.pictureBox_Top1);
            this.Controls.Add(this.pictureBox_Ground);
            this.Controls.Add(this.picturebox_bird);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Flappy jujutsu kaısen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_Up);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox_bird;
        private System.Windows.Forms.PictureBox pictureBox_Ground;
        private System.Windows.Forms.PictureBox pictureBox_Top1;
        private System.Windows.Forms.PictureBox picturebox_top;
        private System.Windows.Forms.Timer time_GameControl;
        private System.Windows.Forms.Label label1;
    }
}

