namespace ISC_Win_WinForm_GUI
{
    partial class ProgressBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressBar));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_cancel = new System.Windows.Forms.Button();
            this.tb_content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 74);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(429, 29);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 2;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(195, 116);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(94, 41);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // tb_content
            // 
            this.tb_content.BackColor = System.Drawing.SystemColors.Control;
            this.tb_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_content.Location = new System.Drawing.Point(34, 15);
            this.tb_content.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.ReadOnly = true;
            this.tb_content.Size = new System.Drawing.Size(429, 49);
            this.tb_content.TabIndex = 5;
            this.tb_content.TabStop = false;
            this.tb_content.Text = "Start Scan...\r\nPlease Wait!";
            this.tb_content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(498, 170);
            this.Controls.Add(this.tb_content);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox tb_content;
    }
}