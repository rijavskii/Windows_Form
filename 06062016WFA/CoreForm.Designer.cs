namespace WindowsForm
{
    partial class CoreForm
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
            this.Data = new System.Windows.Forms.Label();
            this.dtpDateNow = new System.Windows.Forms.DateTimePicker();
            this.ShowDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(12, 40);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(30, 13);
            this.Data.TabIndex = 0;
            this.Data.Text = "Date";
            this.Data.MouseLeave += new System.EventHandler(this.Data_MouseLeave);
            this.Data.MouseHover += new System.EventHandler(this.Data_MouseHover);
            // 
            // dtpDateNow
            // 
            this.dtpDateNow.AllowDrop = true;
            this.dtpDateNow.CustomFormat = "dd/MM/yyyy";
            this.dtpDateNow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateNow.Location = new System.Drawing.Point(87, 35);
            this.dtpDateNow.Name = "dtpDateNow";
            this.dtpDateNow.Size = new System.Drawing.Size(79, 20);
            this.dtpDateNow.TabIndex = 4;
            this.dtpDateNow.Value = new System.DateTime(2016, 6, 6, 12, 3, 0, 0);
            // 
            // ShowDate
            // 
            this.ShowDate.Location = new System.Drawing.Point(186, 36);
            this.ShowDate.Name = "ShowDate";
            this.ShowDate.Size = new System.Drawing.Size(75, 23);
            this.ShowDate.TabIndex = 4;
            this.ShowDate.Text = "Show Date";
            this.ShowDate.UseVisualStyleBackColor = true;
            this.ShowDate.Click += new System.EventHandler(this.ShowDate_Click);
            // 
            // CoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(559, 360);
            this.Controls.Add(this.ShowDate);
            this.Controls.Add(this.dtpDateNow);
            this.Controls.Add(this.Data);
            this.MinimizeBox = false;
            this.Name = "CoreForm";
            this.Text = "My first form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.DateTimePicker dtpDateNow;
        private System.Windows.Forms.Button ShowDate;
    }
}

