namespace WindowsFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslPersonalDetails = new System.Windows.Forms.ToolStripButton();
            this.tslMedicalDetails = new System.Windows.Forms.ToolStripButton();
            this.tslComprehensivePersonalRecord = new System.Windows.Forms.ToolStripButton();
            this.tslEmergencyPersonalHealthRecord = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslPersonalDetails,
            this.tslMedicalDetails,
            this.tslComprehensivePersonalRecord,
            this.tslEmergencyPersonalHealthRecord});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslPersonalDetails
            // 
            this.tslPersonalDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslPersonalDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslPersonalDetails.Name = "tslPersonalDetails";
            this.tslPersonalDetails.Size = new System.Drawing.Size(94, 22);
            this.tslPersonalDetails.Text = "Personal Details";
            this.tslPersonalDetails.Click += new System.EventHandler(this.tslPersonalDetails_Click);
            // 
            // tslMedicalDetails
            // 
            this.tslMedicalDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslMedicalDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslMedicalDetails.Name = "tslMedicalDetails";
            this.tslMedicalDetails.Size = new System.Drawing.Size(91, 22);
            this.tslMedicalDetails.Text = "Medical Details";
            this.tslMedicalDetails.Click += new System.EventHandler(this.tslMedicalDetails_Click);
            // 
            // tslComprehensivePersonalRecord
            // 
            this.tslComprehensivePersonalRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslComprehensivePersonalRecord.Image = ((System.Drawing.Image)(resources.GetObject("tslComprehensivePersonalRecord.Image")));
            this.tslComprehensivePersonalRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslComprehensivePersonalRecord.Name = "tslComprehensivePersonalRecord";
            this.tslComprehensivePersonalRecord.Size = new System.Drawing.Size(182, 22);
            this.tslComprehensivePersonalRecord.Text = "Comprehensive Personal Record";
            // 
            // tslEmergencyPersonalHealthRecord
            // 
            this.tslEmergencyPersonalHealthRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslEmergencyPersonalHealthRecord.Image = ((System.Drawing.Image)(resources.GetObject("tslEmergencyPersonalHealthRecord.Image")));
            this.tslEmergencyPersonalHealthRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslEmergencyPersonalHealthRecord.Name = "tslEmergencyPersonalHealthRecord";
            this.tslEmergencyPersonalHealthRecord.Size = new System.Drawing.Size(196, 22);
            this.tslEmergencyPersonalHealthRecord.Text = "Emergency Personal Health Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "immanuelsuleiman";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 361);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tslPersonalDetails;
        private System.Windows.Forms.ToolStripButton tslMedicalDetails;
        private System.Windows.Forms.ToolStripButton tslComprehensivePersonalRecord;
        private System.Windows.Forms.ToolStripButton tslEmergencyPersonalHealthRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}