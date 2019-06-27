namespace SecondExam
{
    partial class Form1
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
            this.Index = new System.Windows.Forms.Label();
            this.saveLinkLabel = new System.Windows.Forms.LinkLabel();
            this.transactionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.searchLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.Location = new System.Drawing.Point(12, 9);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(35, 13);
            this.Index.TabIndex = 0;
            this.Index.Text = "label1";
            // 
            // saveLinkLabel
            // 
            this.saveLinkLabel.AutoSize = true;
            this.saveLinkLabel.Location = new System.Drawing.Point(234, 125);
            this.saveLinkLabel.Name = "saveLinkLabel";
            this.saveLinkLabel.Size = new System.Drawing.Size(164, 13);
            this.saveLinkLabel.TabIndex = 1;
            this.saveLinkLabel.TabStop = true;
            this.saveLinkLabel.Text = "Save Customer and Account Info";
            this.saveLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saveLinkLabel_LinkClicked);
            // 
            // transactionLinkLabel
            // 
            this.transactionLinkLabel.AutoSize = true;
            this.transactionLinkLabel.Location = new System.Drawing.Point(234, 159);
            this.transactionLinkLabel.Name = "transactionLinkLabel";
            this.transactionLinkLabel.Size = new System.Drawing.Size(63, 13);
            this.transactionLinkLabel.TabIndex = 2;
            this.transactionLinkLabel.TabStop = true;
            this.transactionLinkLabel.Text = "Transaction";
            this.transactionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.transactionLinkLabel_LinkClicked);
            // 
            // searchLinkLabel
            // 
            this.searchLinkLabel.AutoSize = true;
            this.searchLinkLabel.Location = new System.Drawing.Point(237, 210);
            this.searchLinkLabel.Name = "searchLinkLabel";
            this.searchLinkLabel.Size = new System.Drawing.Size(173, 13);
            this.searchLinkLabel.TabIndex = 3;
            this.searchLinkLabel.TabStop = true;
            this.searchLinkLabel.Text = "Search Customer and Account Info";
            this.searchLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.searchLinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchLinkLabel);
            this.Controls.Add(this.transactionLinkLabel);
            this.Controls.Add(this.saveLinkLabel);
            this.Controls.Add(this.Index);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Index;
        private System.Windows.Forms.LinkLabel saveLinkLabel;
        private System.Windows.Forms.LinkLabel transactionLinkLabel;
        private System.Windows.Forms.LinkLabel searchLinkLabel;
    }
}

