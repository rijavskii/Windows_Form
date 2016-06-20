namespace WF2
{
    partial class UcCross
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
            this.tbWheel = new System.Windows.Forms.TextBox();
            this.lbWheel = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.tbSpeedCount = new System.Windows.Forms.TextBox();
            this.lbSpeedCount = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbWheel);
            this.groupBox1.Controls.Add(this.lbWheel);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.cbColor);
            this.groupBox1.Controls.Add(this.lbColor);
            this.groupBox1.Controls.Add(this.tbSpeedCount);
            this.groupBox1.Controls.Add(this.lbSpeedCount);
            this.groupBox1.Controls.Add(this.tbSize);
            this.groupBox1.Controls.Add(this.lbSize);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cross";
            // 
            // tbWheel
            // 
            this.tbWheel.Location = new System.Drawing.Point(98, 76);
            this.tbWheel.Name = "tbWheel";
            this.tbWheel.Size = new System.Drawing.Size(82, 20);
            this.tbWheel.TabIndex = 21;
            // 
            // lbWheel
            // 
            this.lbWheel.AutoSize = true;
            this.lbWheel.Location = new System.Drawing.Point(54, 76);
            this.lbWheel.Name = "lbWheel";
            this.lbWheel.Size = new System.Drawing.Size(38, 13);
            this.lbWheel.TabIndex = 20;
            this.lbWheel.Text = "Wheel";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(98, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(82, 20);
            this.tbName.TabIndex = 19;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(54, 26);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Name";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(98, 126);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(82, 21);
            this.cbColor.TabIndex = 17;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(54, 129);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 16;
            this.lbColor.Text = "Color";
            // 
            // tbSpeedCount
            // 
            this.tbSpeedCount.Location = new System.Drawing.Point(129, 101);
            this.tbSpeedCount.Name = "tbSpeedCount";
            this.tbSpeedCount.Size = new System.Drawing.Size(51, 20);
            this.tbSpeedCount.TabIndex = 15;
            // 
            // lbSpeedCount
            // 
            this.lbSpeedCount.AutoSize = true;
            this.lbSpeedCount.Location = new System.Drawing.Point(54, 104);
            this.lbSpeedCount.Name = "lbSpeedCount";
            this.lbSpeedCount.Size = new System.Drawing.Size(69, 13);
            this.lbSpeedCount.TabIndex = 14;
            this.lbSpeedCount.Text = "Speed Count";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(98, 51);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(82, 20);
            this.tbSize.TabIndex = 13;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(54, 51);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(27, 13);
            this.lbSize.TabIndex = 12;
            this.lbSize.Text = "Size";
            // 
            // UcCross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcCross";
            this.Size = new System.Drawing.Size(235, 170);
            this.Load += new System.EventHandler(this.UcCross_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbWheel;
        private System.Windows.Forms.Label lbWheel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox tbSpeedCount;
        private System.Windows.Forms.Label lbSpeedCount;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label lbSize;
    }
}
