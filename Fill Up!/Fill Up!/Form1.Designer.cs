namespace Fill_Up_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pavadinimas = new System.Windows.Forms.Label();
            this.ivertintiBokala = new System.Windows.Forms.Button();
            this.bokalas = new System.Windows.Forms.PictureBox();
            this.megstamiausiBarai = new System.Windows.Forms.Button();
            this.artimiausiBarai = new System.Windows.Forms.Button();
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
            this.pavadinimas.Location = new System.Drawing.Point(156, 43);
            this.pavadinimas.Name = "pavadinimas";
            this.pavadinimas.Size = new System.Drawing.Size(178, 45);
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
            this.ivertintiBokala.Location = new System.Drawing.Point(139, 165);
            this.ivertintiBokala.Name = "ivertintiBokala";
            this.ivertintiBokala.Size = new System.Drawing.Size(207, 56);
            this.ivertintiBokala.TabIndex = 1;
            this.ivertintiBokala.Text = "Įvertinti bokalą\r\n";
            this.ivertintiBokala.UseVisualStyleBackColor = false;
            this.ivertintiBokala.Click += new System.EventHandler(this.button1_Click);
            // 
            // bokalas
            // 
            this.bokalas.BackColor = System.Drawing.Color.Transparent;
            this.bokalas.Image = ((System.Drawing.Image)(resources.GetObject("bokalas.Image")));
            this.bokalas.Location = new System.Drawing.Point(302, 24);
            this.bokalas.Name = "bokalas";
            this.bokalas.Size = new System.Drawing.Size(127, 88);
            this.bokalas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bokalas.TabIndex = 3;
            this.bokalas.TabStop = false;
            // 
            // megstamiausiBarai
            // 
            this.megstamiausiBarai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.megstamiausiBarai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.megstamiausiBarai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.megstamiausiBarai.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.megstamiausiBarai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.megstamiausiBarai.Location = new System.Drawing.Point(89, 265);
            this.megstamiausiBarai.Name = "megstamiausiBarai";
            this.megstamiausiBarai.Size = new System.Drawing.Size(312, 56);
            this.megstamiausiBarai.TabIndex = 4;
            this.megstamiausiBarai.Text = "Mano mėgstamiausi barai";
            this.megstamiausiBarai.UseVisualStyleBackColor = false;
            // 
            // artimiausiBarai
            // 
            this.artimiausiBarai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.artimiausiBarai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.artimiausiBarai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artimiausiBarai.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artimiausiBarai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.artimiausiBarai.Location = new System.Drawing.Point(139, 357);
            this.artimiausiBarai.Name = "artimiausiBarai";
            this.artimiausiBarai.Size = new System.Drawing.Size(207, 56);
            this.artimiausiBarai.TabIndex = 5;
            this.artimiausiBarai.Text = "Artimiausi barai";
            this.artimiausiBarai.UseVisualStyleBackColor = false;
            this.artimiausiBarai.Click += new System.EventHandler(this.artimiausiBarai_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 534);
            this.Controls.Add(this.artimiausiBarai);
            this.Controls.Add(this.megstamiausiBarai);
            this.Controls.Add(this.ivertintiBokala);
            this.Controls.Add(this.pavadinimas);
            this.Controls.Add(this.bokalas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.bokalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pavadinimas;
        private System.Windows.Forms.Button ivertintiBokala;
        private System.Windows.Forms.PictureBox bokalas;
        private System.Windows.Forms.Button megstamiausiBarai;
        private System.Windows.Forms.Button artimiausiBarai;
    }
}

