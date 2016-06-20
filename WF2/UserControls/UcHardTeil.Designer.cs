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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMaterial = new System.Windows.Forms.TextBox();
            this.lbMaterial = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbForkType = new System.Windows.Forms.TextBox();
            this.lbForkType = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaterial);
            this.groupBox1.Controls.Add(this.lbMaterial);
            this.groupBox1.Controls.Add(this.cbColor);
            this.groupBox1.Controls.Add(this.lbColor);
            this.groupBox1.Controls.Add(this.tbSize);
            this.groupBox1.Controls.Add(this.lbSize);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.tbForkType);
            this.groupBox1.Controls.Add(this.lbForkType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hard Teil";
            // 
            // tbMaterial
            // 
            this.tbMaterial.Location = new System.Drawing.Point(100, 99);
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.Size = new System.Drawing.Size(85, 20);
            this.tbMaterial.TabIndex = 23;
            // 
            // lbMaterial
            // 
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.Location = new System.Drawing.Point(50, 102);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(44, 13);
            this.lbMaterial.TabIndex = 22;
            this.lbMaterial.Text = "Material";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(94, 127);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(91, 21);
            this.cbColor.TabIndex = 21;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(50, 127);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 20;
            this.lbColor.Text = "Color";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(94, 48);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(91, 20);
            this.tbSize.TabIndex = 19;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(50, 51);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(27, 13);
            this.lbSize.TabIndex = 18;
            this.lbSize.Text = "Size";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(85, 20);
            this.tbName.TabIndex = 16;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(50, 26);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "Name";
            // 
            // tbForkType
            // 
            this.tbForkType.Location = new System.Drawing.Point(111, 75);
            this.tbForkType.Name = "tbForkType";
            this.tbForkType.Size = new System.Drawing.Size(74, 20);
            this.tbForkType.TabIndex = 17;
            // 
            // lbForkType
            // 
            this.lbForkType.AutoSize = true;
            this.lbForkType.Location = new System.Drawing.Point(50, 78);
            this.lbForkType.Name = "lbForkType";
            this.lbForkType.Size = new System.Drawing.Size(55, 13);
            this.lbForkType.TabIndex = 15;
            this.lbForkType.Text = "Fork Type";
            // 
            // UcHardTeil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcHardTeil";
            this.Size = new System.Drawing.Size(235, 170);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMaterial;
        private System.Windows.Forms.Label lbMaterial;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbForkType;
        private System.Windows.Forms.Label lbForkType;
    }
}
