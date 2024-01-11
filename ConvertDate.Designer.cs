namespace NotifyIconSampleCSharp
{
    partial class ConvertDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertDate));
            this.rbshtomi = new System.Windows.Forms.RadioButton();
            this.rbmitosh = new System.Windows.Forms.RadioButton();
            this.mtxtDate = new System.Windows.Forms.MaskedTextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbshtomi
            // 
            this.rbshtomi.AutoSize = true;
            this.rbshtomi.Checked = true;
            this.rbshtomi.Location = new System.Drawing.Point(357, 14);
            this.rbshtomi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbshtomi.Name = "rbshtomi";
            this.rbshtomi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbshtomi.Size = new System.Drawing.Size(121, 24);
            this.rbshtomi.TabIndex = 0;
            this.rbshtomi.TabStop = true;
            this.rbshtomi.Text = "شمسی به میلادی";
            this.rbshtomi.UseVisualStyleBackColor = true;
            // 
            // rbmitosh
            // 
            this.rbmitosh.AutoSize = true;
            this.rbmitosh.Location = new System.Drawing.Point(184, 14);
            this.rbmitosh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbmitosh.Name = "rbmitosh";
            this.rbmitosh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbmitosh.Size = new System.Drawing.Size(121, 24);
            this.rbmitosh.TabIndex = 1;
            this.rbmitosh.Text = "میلادی به شمسی";
            this.rbmitosh.UseVisualStyleBackColor = true;
            // 
            // mtxtDate
            // 
            this.mtxtDate.Location = new System.Drawing.Point(184, 48);
            this.mtxtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxtDate.Mask = "0000/00/00";
            this.mtxtDate.Name = "mtxtDate";
            this.mtxtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtxtDate.Size = new System.Drawing.Size(294, 27);
            this.mtxtDate.TabIndex = 2;
            this.mtxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(13, 48);
            this.lblC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(49, 20);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "-----";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(28, 85);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(450, 35);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "تبدیل";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConvertDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 125);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.mtxtDate);
            this.Controls.Add(this.rbmitosh);
            this.Controls.Add(this.rbshtomi);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConvertDate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تبدیل تاریخ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbshtomi;
        private System.Windows.Forms.RadioButton rbmitosh;
        private System.Windows.Forms.MaskedTextBox mtxtDate;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnConvert;
    }
}