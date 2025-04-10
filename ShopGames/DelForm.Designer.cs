namespace ShopGames
{
    partial class DelForm
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
            this.delButton = new System.Windows.Forms.Button();
            this.selectedComboBox = new System.Windows.Forms.ComboBox();
            this.selectedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(8, 147);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(590, 47);
            this.delButton.TabIndex = 0;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // selectedComboBox
            // 
            this.selectedComboBox.FormattingEnabled = true;
            this.selectedComboBox.Location = new System.Drawing.Point(8, 12);
            this.selectedComboBox.Name = "selectedComboBox";
            this.selectedComboBox.Size = new System.Drawing.Size(590, 33);
            this.selectedComboBox.TabIndex = 1;
            this.selectedComboBox.SelectedIndexChanged += new System.EventHandler(this.selectedComboBox_SelectedIndexChanged);
            // 
            // selectedTextBox
            // 
            this.selectedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedTextBox.ForeColor = System.Drawing.Color.Red;
            this.selectedTextBox.Location = new System.Drawing.Point(8, 68);
            this.selectedTextBox.Name = "selectedTextBox";
            this.selectedTextBox.ReadOnly = true;
            this.selectedTextBox.Size = new System.Drawing.Size(587, 38);
            this.selectedTextBox.TabIndex = 2;
            this.selectedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 213);
            this.Controls.Add(this.selectedTextBox);
            this.Controls.Add(this.selectedComboBox);
            this.Controls.Add(this.delButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DelForm";
            this.Text = "Форма удаления объектов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.ComboBox selectedComboBox;
        private System.Windows.Forms.TextBox selectedTextBox;
    }
}