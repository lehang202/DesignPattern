
namespace Notepad
{
    partial class GotoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bntOK = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Line number";
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(479, 14);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(80, 32);
            this.bntOK.TabIndex = 1;
            this.bntOK.Text = "OK";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(115, 17);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(347, 26);
            this.inputBox.TabIndex = 2;
            // 
            // GotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 59);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.label1);
            this.Name = "GotoForm";
            this.Text = "GotoForm";
            this.Load += new System.EventHandler(this.GotoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.TextBox inputBox;
    }
}