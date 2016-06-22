namespace WF2
{
    partial class DeleteBike
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.tbBikeId = new System.Windows.Forms.TextBox();
            this.btShow = new System.Windows.Forms.Button();
            this.panelBike = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(218, 230);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(55, 25);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(157, 230);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(55, 25);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(24, 31);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(42, 13);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Bike ID";
            // 
            // tbBikeId
            // 
            this.tbBikeId.Location = new System.Drawing.Point(72, 28);
            this.tbBikeId.Name = "tbBikeId";
            this.tbBikeId.Size = new System.Drawing.Size(100, 20);
            this.tbBikeId.TabIndex = 2;
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(188, 28);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(59, 19);
            this.btShow.TabIndex = 3;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // panelBike
            // 
            this.panelBike.Location = new System.Drawing.Point(27, 66);
            this.panelBike.Name = "panelBike";
            this.panelBike.Size = new System.Drawing.Size(219, 155);
            this.panelBike.TabIndex = 4;
            // 
            // DeleteBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 263);
            this.Controls.Add(this.panelBike);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.tbBikeId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteBike";
            this.ShowInTaskbar = false;
            this.Text = "DeleteBike";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbBikeId;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Panel panelBike;
    }
}