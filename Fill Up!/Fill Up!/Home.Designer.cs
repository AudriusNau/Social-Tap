namespace Fill_Up_
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pavadinimas = new System.Windows.Forms.Label();
            this.ivertintiBokala = new System.Windows.Forms.Button();
            this.bokalas = new System.Windows.Forms.PictureBox();
            this.nearestBars = new System.Windows.Forms.Button();
            this.favoriteBars = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bokalas)).BeginInit();
            this.SuspendLayout();
            // 
            // pavadinimas
            // 
            this.pavadinimas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pavadinimas.AutoSize = true;
            this.pavadinimas.BackColor = System.Drawing.Color.Transparent;
            this.pavadinimas.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pavadinimas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pavadinimas.Location = new System.Drawing.Point(208, 53);
            this.pavadinimas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pavadinimas.Name = "pavadinimas";
            this.pavadinimas.Size = new System.Drawing.Size(222, 57);
            this.pavadinimas.TabIndex = 0;
            this.pavadinimas.Text = "Fill Up!";
            this.pavadinimas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ivertintiBokala
            // 
            this.ivertintiBokala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ivertintiBokala.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ivertintiBokala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ivertintiBokala.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ivertintiBokala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ivertintiBokala.Location = new System.Drawing.Point(185, 203);
            this.ivertintiBokala.Margin = new System.Windows.Forms.Padding(4);
            this.ivertintiBokala.Name = "ivertintiBokala";
            this.ivertintiBokala.Size = new System.Drawing.Size(276, 69);
            this.ivertintiBokala.TabIndex = 1;
            this.ivertintiBokala.Text = "Įvertinti bokalą\r\n";
            this.ivertintiBokala.UseVisualStyleBackColor = false;
            this.ivertintiBokala.Click += new System.EventHandler(this.button1_Click);
            // 
            // bokalas
            // 
            this.bokalas.BackColor = System.Drawing.Color.Transparent;
            this.bokalas.Image = ((System.Drawing.Image)(resources.GetObject("bokalas.Image")));
            this.bokalas.Location = new System.Drawing.Point(403, 30);
            this.bokalas.Margin = new System.Windows.Forms.Padding(4);
            this.bokalas.Name = "bokalas";
            this.bokalas.Size = new System.Drawing.Size(169, 108);
            this.bokalas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bokalas.TabIndex = 3;
            this.bokalas.TabStop = false;
            // 
            // nearestBars
            // 
            this.nearestBars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nearestBars.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nearestBars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nearestBars.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nearestBars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nearestBars.Location = new System.Drawing.Point(185, 429);
            this.nearestBars.Margin = new System.Windows.Forms.Padding(4);
            this.nearestBars.Name = "nearestBars";
            this.nearestBars.Size = new System.Drawing.Size(276, 69);
            this.nearestBars.TabIndex = 6;
            this.nearestBars.Text = "Artimiausi barai";
            this.nearestBars.UseVisualStyleBackColor = false;
            this.nearestBars.Click += new System.EventHandler(this.nearestBars_Click);
            // 
            // favoriteBars
            // 
            this.favoriteBars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.favoriteBars.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.favoriteBars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favoriteBars.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoriteBars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.favoriteBars.Location = new System.Drawing.Point(161, 319);
            this.favoriteBars.Margin = new System.Windows.Forms.Padding(4);
            this.favoriteBars.Name = "favoriteBars";
            this.favoriteBars.Size = new System.Drawing.Size(319, 69);
            this.favoriteBars.TabIndex = 7;
            this.favoriteBars.Text = "Mėgstamiausi barai";
            this.favoriteBars.UseVisualStyleBackColor = false;
            this.favoriteBars.Click += new System.EventHandler(this.favoriteBars_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 657);
            this.Controls.Add(this.favoriteBars);
            this.Controls.Add(this.nearestBars);
            this.Controls.Add(this.ivertintiBokala);
            this.Controls.Add(this.pavadinimas);
            this.Controls.Add(this.bokalas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Pradžia";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bokalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pavadinimas;
        private System.Windows.Forms.Button ivertintiBokala;
        private System.Windows.Forms.PictureBox bokalas;
        private System.Windows.Forms.Button nearestBars;
        private System.Windows.Forms.Button favoriteBars;
    }
}

