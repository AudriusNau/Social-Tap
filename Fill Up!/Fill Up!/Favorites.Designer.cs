namespace Fill_Up_
{
    partial class Favorites
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
            this.bar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bar
            // 
            this.bar.AutoSize = true;
            this.bar.BackColor = System.Drawing.Color.Transparent;
            this.bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bar.Location = new System.Drawing.Point(164, 269);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(341, 72);
            this.bar.TabIndex = 29;
            this.bar.Text = "Šiuo metu Jūs neturite \r\nmėgstamiausių barų.";
            this.bar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bar.Click += new System.EventHandler(this.bar_Click);
            // 
            // Favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fill_Up_.Properties.Resources._1680175__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 657);
            this.Controls.Add(this.bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Favorites";
            this.Text = "Mėgstamiausi barai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bar;
    }
}