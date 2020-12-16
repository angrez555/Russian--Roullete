namespace Russian_Roullete
{
    partial class game
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
            this.label1 = new System.Windows.Forms.Label();
            this.Loadbt = new System.Windows.Forms.Button();
            this.buttonspin = new System.Windows.Forms.Button();
            this.buttonshhot = new System.Windows.Forms.Button();
            this.Shootawaybt = new System.Windows.Forms.Button();
            this.playagain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Russian Roullete";
            // 
            // Loadbt
            // 
            this.Loadbt.Location = new System.Drawing.Point(497, 89);
            this.Loadbt.Name = "Loadbt";
            this.Loadbt.Size = new System.Drawing.Size(75, 23);
            this.Loadbt.TabIndex = 1;
            this.Loadbt.Text = "Load";
            this.Loadbt.UseVisualStyleBackColor = true;
            this.Loadbt.Click += new System.EventHandler(this.Loadbt_Click);
            // 
            // buttonspin
            // 
            this.buttonspin.Location = new System.Drawing.Point(497, 147);
            this.buttonspin.Name = "buttonspin";
            this.buttonspin.Size = new System.Drawing.Size(75, 23);
            this.buttonspin.TabIndex = 2;
            this.buttonspin.Text = "Spin";
            this.buttonspin.UseVisualStyleBackColor = true;
            this.buttonspin.Click += new System.EventHandler(this.buttonspin_Click);
            // 
            // buttonshhot
            // 
            this.buttonshhot.Location = new System.Drawing.Point(497, 202);
            this.buttonshhot.Name = "buttonshhot";
            this.buttonshhot.Size = new System.Drawing.Size(75, 23);
            this.buttonshhot.TabIndex = 3;
            this.buttonshhot.Text = "shoot";
            this.buttonshhot.UseVisualStyleBackColor = true;
            this.buttonshhot.Click += new System.EventHandler(this.buttonshhot_Click);
            // 
            // Shootawaybt
            // 
            this.Shootawaybt.Location = new System.Drawing.Point(497, 261);
            this.Shootawaybt.Name = "Shootawaybt";
            this.Shootawaybt.Size = new System.Drawing.Size(75, 23);
            this.Shootawaybt.TabIndex = 4;
            this.Shootawaybt.Text = "ShootAway ";
            this.Shootawaybt.UseVisualStyleBackColor = true;
            this.Shootawaybt.Click += new System.EventHandler(this.Shootawaybt_Click);
            // 
            // playagain
            // 
            this.playagain.Location = new System.Drawing.Point(497, 307);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(75, 23);
            this.playagain.TabIndex = 5;
            this.playagain.Text = "Play Again";
            this.playagain.UseVisualStyleBackColor = true;
            this.playagain.Click += new System.EventHandler(this.playagain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(88, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 258);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(600, 377);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playagain);
            this.Controls.Add(this.Shootawaybt);
            this.Controls.Add(this.buttonshhot);
            this.Controls.Add(this.buttonspin);
            this.Controls.Add(this.Loadbt);
            this.Controls.Add(this.label1);
            this.Name = "game";
            this.Text = "game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Loadbt;
        private System.Windows.Forms.Button buttonspin;
        private System.Windows.Forms.Button buttonshhot;
        private System.Windows.Forms.Button Shootawaybt;
        private System.Windows.Forms.Button playagain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}