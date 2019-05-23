namespace ArrayFormThirdClass
{
    partial class HomeForm
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
            this.showButton = new System.Windows.Forms.Button();
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.reverseButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.duplicateArray = new System.Windows.Forms.Button();
            this.uniqueButtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(300, 59);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(70, 61);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(224, 334);
            this.showRichTextBox.TabIndex = 1;
            this.showRichTextBox.Text = "";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(219, 32);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(70, 32);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(143, 20);
            this.inputTextBox.TabIndex = 3;
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(300, 106);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(75, 23);
            this.reverseButton.TabIndex = 4;
            this.reverseButton.Text = "Reverse Array";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(301, 158);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(75, 23);
            this.sumButton.TabIndex = 5;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(300, 198);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 6;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // duplicateArray
            // 
            this.duplicateArray.Location = new System.Drawing.Point(301, 250);
            this.duplicateArray.Name = "duplicateArray";
            this.duplicateArray.Size = new System.Drawing.Size(75, 23);
            this.duplicateArray.TabIndex = 7;
            this.duplicateArray.Text = "Duplicate";
            this.duplicateArray.UseVisualStyleBackColor = true;
            this.duplicateArray.Click += new System.EventHandler(this.duplicateArray_Click);
            // 
            // uniqueButtton
            // 
            this.uniqueButtton.Location = new System.Drawing.Point(301, 279);
            this.uniqueButtton.Name = "uniqueButtton";
            this.uniqueButtton.Size = new System.Drawing.Size(75, 23);
            this.uniqueButtton.TabIndex = 8;
            this.uniqueButtton.Text = "Unique";
            this.uniqueButtton.UseVisualStyleBackColor = true;
            this.uniqueButtton.Click += new System.EventHandler(this.uniqueButtton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uniqueButtton);
            this.Controls.Add(this.duplicateArray);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.showRichTextBox);
            this.Controls.Add(this.showButton);
            this.Name = "HomeForm";
            this.Text = "ArrayForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.RichTextBox showRichTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button duplicateArray;
        private System.Windows.Forms.Button uniqueButtton;
    }
}

