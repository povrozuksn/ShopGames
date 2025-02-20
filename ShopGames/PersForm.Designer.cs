namespace ShopGames
{
    partial class PersForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.PersPictureBox = new System.Windows.Forms.PictureBox();
            this.StyleLabel = new System.Windows.Forms.Label();
            this.DeskTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(36, 31);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(64, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "label1";
            // 
            // PersPictureBox
            // 
            this.PersPictureBox.Location = new System.Drawing.Point(36, 79);
            this.PersPictureBox.Name = "PersPictureBox";
            this.PersPictureBox.Size = new System.Drawing.Size(379, 466);
            this.PersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PersPictureBox.TabIndex = 1;
            this.PersPictureBox.TabStop = false;
            // 
            // StyleLabel
            // 
            this.StyleLabel.AutoSize = true;
            this.StyleLabel.Location = new System.Drawing.Point(467, 31);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(64, 25);
            this.StyleLabel.TabIndex = 2;
            this.StyleLabel.Text = "label1";
            // 
            // DeskTextBox
            // 
            this.DeskTextBox.Location = new System.Drawing.Point(467, 80);
            this.DeskTextBox.Multiline = true;
            this.DeskTextBox.Name = "DeskTextBox";
            this.DeskTextBox.Size = new System.Drawing.Size(395, 465);
            this.DeskTextBox.TabIndex = 3;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(467, 583);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(64, 25);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "label1";
            // 
            // PersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 646);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DeskTextBox);
            this.Controls.Add(this.StyleLabel);
            this.Controls.Add(this.PersPictureBox);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersForm";
            this.Text = "PersForm";
            ((System.ComponentModel.ISupportInitialize)(this.PersPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox PersPictureBox;
        private System.Windows.Forms.Label StyleLabel;
        private System.Windows.Forms.TextBox DeskTextBox;
        private System.Windows.Forms.Label PriceLabel;
    }
}