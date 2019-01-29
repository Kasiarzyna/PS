namespace Wyscigi
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.distance1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trophy1 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.explosion1 = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.distance2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trophy2 = new System.Windows.Forms.PictureBox();
            this.AI4 = new System.Windows.Forms.PictureBox();
            this.AI3 = new System.Windows.Forms.PictureBox();
            this.explosion2 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.roadTrack3 = new System.Windows.Forms.PictureBox();
            this.roadTrack4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trophy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trophy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(139, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odległość:";
            // 
            // distance1
            // 
            this.distance1.AutoSize = true;
            this.distance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.distance1.Location = new System.Drawing.Point(230, 499);
            this.distance1.Name = "distance1";
            this.distance1.Size = new System.Drawing.Size(26, 17);
            this.distance1.TabIndex = 1;
            this.distance1.Text = "00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(364, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(291, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "      Unikaj innych samochodów\r\nUżywaj lewego i prawego przycisku\r\n      żeby por" +
    "uszać samochodem\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.trophy1);
            this.panel1.Controls.Add(this.player1);
            this.panel1.Controls.Add(this.explosion1);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 467);
            this.panel1.TabIndex = 4;
            // 
            // trophy1
            // 
            this.trophy1.Image = global::Wyscigi.Properties.Resources.win;
            this.trophy1.Location = new System.Drawing.Point(-2, -2);
            this.trophy1.Name = "trophy1";
            this.trophy1.Size = new System.Drawing.Size(376, 462);
            this.trophy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trophy1.TabIndex = 6;
            this.trophy1.TabStop = false;
            // 
            // player1
            // 
            this.player1.Image = global::Wyscigi.Properties.Resources.ambulance;
            this.player1.Location = new System.Drawing.Point(161, 286);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(50, 101);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 5;
            this.player1.TabStop = false;
            // 
            // explosion1
            // 
            this.explosion1.Image = global::Wyscigi.Properties.Resources.explosion;
            this.explosion1.Location = new System.Drawing.Point(153, 234);
            this.explosion1.Name = "explosion1";
            this.explosion1.Size = new System.Drawing.Size(64, 64);
            this.explosion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion1.TabIndex = 4;
            this.explosion1.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.Image = global::Wyscigi.Properties.Resources.carGreen;
            this.AI2.Location = new System.Drawing.Point(294, 85);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 101);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI2.TabIndex = 3;
            this.AI2.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.Image = global::Wyscigi.Properties.Resources.CarRed;
            this.AI1.Location = new System.Drawing.Point(66, 19);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI1.TabIndex = 2;
            this.AI1.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::Wyscigi.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(-3, -222);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(385, 630);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 1;
            this.roadTrack2.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::Wyscigi.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(-2, -638);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(385, 632);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // distance2
            // 
            this.distance2.AutoSize = true;
            this.distance2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.distance2.Location = new System.Drawing.Point(746, 499);
            this.distance2.Name = "distance2";
            this.distance2.Size = new System.Drawing.Size(26, 17);
            this.distance2.TabIndex = 6;
            this.distance2.Text = "00";
            this.distance2.Click += new System.EventHandler(this.distance2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(566, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Odległość przeciwnika:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Controls.Add(this.trophy2);
            this.panel2.Controls.Add(this.AI4);
            this.panel2.Controls.Add(this.AI3);
            this.panel2.Controls.Add(this.explosion2);
            this.panel2.Controls.Add(this.player2);
            this.panel2.Controls.Add(this.roadTrack3);
            this.panel2.Controls.Add(this.roadTrack4);
            this.panel2.Location = new System.Drawing.Point(480, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 468);
            this.panel2.TabIndex = 7;
            // 
            // trophy2
            // 
            this.trophy2.Image = global::Wyscigi.Properties.Resources.win;
            this.trophy2.Location = new System.Drawing.Point(0, 3);
            this.trophy2.Name = "trophy2";
            this.trophy2.Size = new System.Drawing.Size(376, 462);
            this.trophy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trophy2.TabIndex = 10;
            this.trophy2.TabStop = false;
            // 
            // AI4
            // 
            this.AI4.Image = global::Wyscigi.Properties.Resources.CarRed;
            this.AI4.Location = new System.Drawing.Point(283, 100);
            this.AI4.Name = "AI4";
            this.AI4.Size = new System.Drawing.Size(50, 101);
            this.AI4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI4.TabIndex = 9;
            this.AI4.TabStop = false;
            // 
            // AI3
            // 
            this.AI3.Image = global::Wyscigi.Properties.Resources.carGreen;
            this.AI3.Location = new System.Drawing.Point(73, 21);
            this.AI3.Name = "AI3";
            this.AI3.Size = new System.Drawing.Size(50, 101);
            this.AI3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI3.TabIndex = 8;
            this.AI3.TabStop = false;
            // 
            // explosion2
            // 
            this.explosion2.Image = global::Wyscigi.Properties.Resources.explosion;
            this.explosion2.Location = new System.Drawing.Point(167, 236);
            this.explosion2.Name = "explosion2";
            this.explosion2.Size = new System.Drawing.Size(64, 64);
            this.explosion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion2.TabIndex = 7;
            this.explosion2.TabStop = false;
            // 
            // player2
            // 
            this.player2.Image = global::Wyscigi.Properties.Resources.ambulance;
            this.player2.Location = new System.Drawing.Point(174, 288);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(50, 101);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 6;
            this.player2.TabStop = false;
            // 
            // roadTrack3
            // 
            this.roadTrack3.Image = global::Wyscigi.Properties.Resources.roadTrack;
            this.roadTrack3.Location = new System.Drawing.Point(-2, -638);
            this.roadTrack3.Name = "roadTrack3";
            this.roadTrack3.Size = new System.Drawing.Size(385, 630);
            this.roadTrack3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack3.TabIndex = 3;
            this.roadTrack3.TabStop = false;
            // 
            // roadTrack4
            // 
            this.roadTrack4.Image = global::Wyscigi.Properties.Resources.roadTrack;
            this.roadTrack4.Location = new System.Drawing.Point(-2, -222);
            this.roadTrack4.Name = "roadTrack4";
            this.roadTrack4.Size = new System.Drawing.Size(385, 630);
            this.roadTrack4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack4.TabIndex = 2;
            this.roadTrack4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.distance2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.distance1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Wyscigi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moveCar);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stopCar);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trophy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trophy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label distance1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox explosion1;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox trophy1;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label distance2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox explosion2;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox roadTrack3;
        private System.Windows.Forms.PictureBox roadTrack4;
        private System.Windows.Forms.PictureBox AI4;
        private System.Windows.Forms.PictureBox AI3;
        private System.Windows.Forms.PictureBox trophy2;
    }
}

