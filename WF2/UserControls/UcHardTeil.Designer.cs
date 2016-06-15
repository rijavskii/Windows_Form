namespace WF2
{
    partial class UcHardTeil
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.tbForkType = new System.Windows.Forms.TextBox();
            this.lbForkType = new System.Windows.Forms.Label();
            this.lbMaterial = new System.Windows.Forms.Label();
            this.tbMaterial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(88, 112);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(91, 21);
            this.cbColor.TabIndex = 11;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(44, 112);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 10;
            this.lbColor.Text = "Color";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(88, 86);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(91, 20);
            this.tbSize.TabIndex = 9;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(44, 89);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(27, 13);
            this.lbSize.TabIndex = 8;
            this.lbSize.Text = "Size";
            // 
            // tbForkType
            // 
            this.tbForkType.Location = new System.Drawing.Point(105, 60);
            this.tbForkType.Name = "tbForkType";
            this.tbForkType.Size = new System.Drawing.Size(74, 20);
            this.tbForkType.TabIndex = 7;
            // 
            // lbForkType
            // 
            this.lbForkType.AutoSize = true;
            this.lbForkType.Location = new System.Drawing.Point(44, 63);
            this.lbForkType.Name = "lbForkType";
            this.lbForkType.Size = new System.Drawing.Size(55, 13);
            this.lbForkType.TabIndex = 6;
            this.lbForkType.Text = "Fork Type";
            // 
            // lbMaterial
            // 
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.Location = new System.Drawing.Point(44, 37);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(44, 13);
            this.lbMaterial.TabIndex = 6;
            this.lbMaterial.Text = "Material";
            // 
            // tbMaterial
            // 
            this.tbMaterial.Location = new System.Drawing.Point(94, 34);
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.Size = new System.Drawing.Size(85, 20);
            this.tbMaterial.TabIndex = 7;
            // 
            // UcHardTeil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.tbMaterial);
            this.Controls.Add(this.lbMaterial);
            this.Controls.Add(this.tbForkType);
            this.Controls.Add(this.lbForkType);
            this.Name = "UcHardTeil";
            this.Size = new System.Drawing.Size(235, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TextBox tbForkType;
        private System.Windows.Forms.Label lbForkType;
        private System.Windows.Forms.Label lbMaterial;
        private System.Windows.Forms.TextBox tbMaterial;
    }
}
