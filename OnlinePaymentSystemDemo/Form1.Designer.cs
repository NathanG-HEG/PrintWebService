
namespace OnlinePaymentSystemDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.quotaField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(277, 95);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(207, 27);
            this.usernameField.TabIndex = 1;
            // 
            // quotaField
            // 
            this.quotaField.Location = new System.Drawing.Point(319, 162);
            this.quotaField.Name = "quotaField";
            this.quotaField.Size = new System.Drawing.Size(165, 27);
            this.quotaField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount to load:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(301, 45);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 4;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(277, 239);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(94, 29);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 339);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.quotaField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox quotaField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button loadButton;
    }
}

