namespace Fill_Up_
{
    partial class Zemelapis
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBoxBaras = new System.Windows.Forms.TextBox();
            this.textBoxMiestas = new System.Windows.Forms.TextBox();
            this.textBoxGatve = new System.Windows.Forms.TextBox();
            this.baras = new System.Windows.Forms.Label();
            this.miestas = new System.Windows.Forms.Label();
            this.gatve = new System.Windows.Forms.Label();
            this.ieskoti = new System.Windows.Forms.Button();
            this.atgal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::Fill_Up_.Properties.Resources._1680175__2_;
            this.splitContainer1.Panel1.Controls.Add(this.atgal);
            this.splitContainer1.Panel1.Controls.Add(this.ieskoti);
            this.splitContainer1.Panel1.Controls.Add(this.gatve);
            this.splitContainer1.Panel1.Controls.Add(this.miestas);
            this.splitContainer1.Panel1.Controls.Add(this.baras);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxGatve);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxMiestas);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxBaras);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::Fill_Up_.Properties.Resources._1680175__2_;
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(668, 657);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(442, 657);
            this.webBrowser1.TabIndex = 0;
            // 
            // textBoxBaras
            // 
            this.textBoxBaras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxBaras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxBaras.Location = new System.Drawing.Point(38, 88);
            this.textBoxBaras.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBaras.Multiline = true;
            this.textBoxBaras.Name = "textBoxBaras";
            this.textBoxBaras.Size = new System.Drawing.Size(148, 35);
            this.textBoxBaras.TabIndex = 25;
            this.textBoxBaras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBaras.TextChanged += new System.EventHandler(this.textBoxBaras_TextChanged);
            // 
            // textBoxMiestas
            // 
            this.textBoxMiestas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxMiestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxMiestas.Location = new System.Drawing.Point(38, 230);
            this.textBoxMiestas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMiestas.Multiline = true;
            this.textBoxMiestas.Name = "textBoxMiestas";
            this.textBoxMiestas.Size = new System.Drawing.Size(148, 35);
            this.textBoxMiestas.TabIndex = 26;
            this.textBoxMiestas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGatve
            // 
            this.textBoxGatve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxGatve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxGatve.Location = new System.Drawing.Point(38, 360);
            this.textBoxGatve.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGatve.Multiline = true;
            this.textBoxGatve.Name = "textBoxGatve";
            this.textBoxGatve.Size = new System.Drawing.Size(148, 35);
            this.textBoxGatve.TabIndex = 27;
            this.textBoxGatve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // baras
            // 
            this.baras.AutoSize = true;
            this.baras.BackColor = System.Drawing.Color.Transparent;
            this.baras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.baras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.baras.Location = new System.Drawing.Point(58, 48);
            this.baras.Name = "baras";
            this.baras.Size = new System.Drawing.Size(106, 36);
            this.baras.TabIndex = 28;
            this.baras.Text = "Baras:";
            this.baras.Click += new System.EventHandler(this.label3_Click);
            // 
            // miestas
            // 
            this.miestas.AutoSize = true;
            this.miestas.BackColor = System.Drawing.Color.Transparent;
            this.miestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.miestas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.miestas.Location = new System.Drawing.Point(44, 190);
            this.miestas.Name = "miestas";
            this.miestas.Size = new System.Drawing.Size(133, 36);
            this.miestas.TabIndex = 29;
            this.miestas.Text = "Miestas:";
            // 
            // gatve
            // 
            this.gatve.AutoSize = true;
            this.gatve.BackColor = System.Drawing.Color.Transparent;
            this.gatve.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.gatve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gatve.Location = new System.Drawing.Point(57, 320);
            this.gatve.Name = "gatve";
            this.gatve.Size = new System.Drawing.Size(107, 36);
            this.gatve.TabIndex = 30;
            this.gatve.Text = "Gatvė:";
            // 
            // ieskoti
            // 
            this.ieskoti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ieskoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.ieskoti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ieskoti.Location = new System.Drawing.Point(38, 516);
            this.ieskoti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ieskoti.Name = "ieskoti";
            this.ieskoti.Size = new System.Drawing.Size(148, 51);
            this.ieskoti.TabIndex = 31;
            this.ieskoti.Text = "Ieškoti";
            this.ieskoti.UseVisualStyleBackColor = false;
            this.ieskoti.Click += new System.EventHandler(this.ieskoti_Click);
            // 
            // atgal
            // 
            this.atgal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.atgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.atgal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.atgal.Location = new System.Drawing.Point(38, 584);
            this.atgal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.atgal.Name = "atgal";
            this.atgal.Size = new System.Drawing.Size(148, 51);
            this.atgal.TabIndex = 32;
            this.atgal.Text = "Atgal";
            this.atgal.UseVisualStyleBackColor = false;
            this.atgal.Click += new System.EventHandler(this.atgal_Click);
            // 
            // Zemelapis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fill_Up_.Properties.Resources._1680175__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 657);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Zemelapis";
            this.Text = "Barai";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBoxGatve;
        private System.Windows.Forms.TextBox textBoxMiestas;
        private System.Windows.Forms.TextBox textBoxBaras;
        private System.Windows.Forms.Label baras;
        private System.Windows.Forms.Label gatve;
        private System.Windows.Forms.Label miestas;
        private System.Windows.Forms.Button ieskoti;
        private System.Windows.Forms.Button atgal;
    }
}