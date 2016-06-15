namespace WF2
{
    partial class UcMountain
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
            this.lbWeight = new System.Windows.Forms.Label();
            this.tbMaterial = new System.Windows.Forms.TextBox();
            this.lbMaterial = new System.Windows.Forms.Label();
            this.tbBreakType = new System.Windows.Forms.TextBox();
            this.lbBreakType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(94, 114);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(91, 21);
            this.cbColor.TabIndex = 19;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(50, 114);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 18;
            this.lbColor.Text = "Color";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(94, 88);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(91, 20);
            this.tbSize.TabIndex = 17;
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(50, 91);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(41, 13);
            this.lbWeight.TabIndex = 16;
            this.lbWeight.Text = "Weight";
            // 
            // tbMaterial
            // 
            this.tbMaterial.Location = new System.Drawing.Point(100, 36);
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.Size = new System.Drawing.Size(85, 20);
            this.tbMaterial.TabIndex = 14;
            // 
            // lbMaterial
            // 
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.Location = new System.Drawing.Point(50, 39);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(44, 13);
            this.lbMaterial.TabIndex = 12;
            this.lbMaterial.Text = "Material";
            // 
            // tbBreakType
            // 
            this.tbBreakType.Location = new System.Drawing.Point(118, 62);
            this.tbBreakType.Name = "tbBreakType";
            this.tbBreakType.Size = new System.Drawing.Size(67, 20);
            this.tbBreakType.TabIndex = 15;
            // 
            // lbBreakType
            // 
            this.lbBreakType.AutoSize = true;
            this.lbBreakType.Location = new System.Drawing.Point(50, 65);
            this.lbBreakType.Name = "lbBreakType";
            this.lbBreakType.Size = new System.Drawing.Size(62, 13);
            this.lbBreakType.TabIndex = 13;
            this.lbBreakType.Text = "Break Type";
            // 
            // UcMountain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.tbMaterial);
            this.Controls.Add(this.lbMaterial);
            this.Controls.Add(this.tbBreakType);
            this.Controls.Add(this.lbBreakType);
            this.Name = "UcMountain";
            this.Size = new System.Drawing.Size(235, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.TextBox tbMaterial;
        private System.Windows.Forms.Label lbMaterial;
        private System.Windows.Forms.TextBox tbBreakType;
        private System.Windows.Forms.Label lbBreakType;
    }
}
