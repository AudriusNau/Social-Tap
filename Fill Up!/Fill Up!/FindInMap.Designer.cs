﻿namespace Fill_Up_
{
    partial class FindInMap
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
            this.button1 = new System.Windows.Forms.Button();
            this.street = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxBar = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::Fill_Up_.Properties.Resources._1680175__2_;
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.street);
            this.splitContainer1.Panel1.Controls.Add(this.city);
            this.splitContainer1.Panel1.Controls.Add(this.bar);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxStreet);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCity);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxBar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::Fill_Up_.Properties.Resources._1680175__2_;
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(501, 534);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(28, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 41);
            this.button1.TabIndex = 33;
            this.button1.Text = "Ieškoti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.BackColor = System.Drawing.Color.Transparent;
            this.street.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.street.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.street.Location = new System.Drawing.Point(43, 260);
            this.street.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(87, 29);
            this.street.TabIndex = 30;
            this.street.Text = "Gatvė:";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.BackColor = System.Drawing.Color.Transparent;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.city.Location = new System.Drawing.Point(33, 154);
            this.city.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(110, 29);
            this.city.TabIndex = 29;
            this.city.Text = "Miestas:";
            // 
            // bar
            // 
            this.bar.AutoSize = true;
            this.bar.BackColor = System.Drawing.Color.Transparent;
            this.bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bar.Location = new System.Drawing.Point(44, 39);
            this.bar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(87, 29);
            this.bar.TabIndex = 28;
            this.bar.Text = "Baras:";
            this.bar.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxStreet.Location = new System.Drawing.Point(28, 292);
            this.textBoxStreet.Multiline = true;
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(112, 29);
            this.textBoxStreet.TabIndex = 27;
            this.textBoxStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxCity.Location = new System.Drawing.Point(28, 187);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(112, 29);
            this.textBoxCity.TabIndex = 26;
            this.textBoxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBar
            // 
            this.textBoxBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxBar.Location = new System.Drawing.Point(28, 72);
            this.textBoxBar.Multiline = true;
            this.textBoxBar.Name = "textBoxBar";
            this.textBoxBar.Size = new System.Drawing.Size(112, 29);
            this.textBoxBar.TabIndex = 25;
            this.textBoxBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBar.TextChanged += new System.EventHandler(this.textBoxBaras_TextChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(332, 534);
            this.webBrowser1.TabIndex = 0;
            // 
            // FindInMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fill_Up_.Properties.Resources._1680175__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 534);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FindInMap";
            this.Text = "Barai";
            this.Load += new System.EventHandler(this.FindInMap_Load);
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
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxBar;
        private System.Windows.Forms.Label bar;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Button button1;
    }
}