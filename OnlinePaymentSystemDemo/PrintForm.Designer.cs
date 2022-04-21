
namespace OnlinePaymentSystemDemo
{
    partial class PrintForm
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
            this.idField = new System.Windows.Forms.TextBox();
            this.quotaField = new System.Windows.Forms.TextBox();
            this.amount_name = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.loadButton_username = new System.Windows.Forms.Button();
            this.combo_id = new System.Windows.Forms.ComboBox();
            this.combo_product = new System.Windows.Forms.ComboBox();
            this.button_print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.photocopies_nb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.photocopies_in = new System.Windows.Forms.TextBox();
            this.card_id_in = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(174, 17);
            this.idField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(182, 23);
            this.idField.TabIndex = 1;
            // 
            // quotaField
            // 
            this.quotaField.Location = new System.Drawing.Point(174, 50);
            this.quotaField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quotaField.Name = "quotaField";
            this.quotaField.Size = new System.Drawing.Size(145, 23);
            this.quotaField.TabIndex = 3;
            // 
            // amount_name
            // 
            this.amount_name.AutoSize = true;
            this.amount_name.Location = new System.Drawing.Point(23, 56);
            this.amount_name.Name = "amount_name";
            this.amount_name.Size = new System.Drawing.Size(94, 15);
            this.amount_name.TabIndex = 2;
            this.amount_name.Text = "Amount to load:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(263, 34);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 4;
            // 
            // loadButton_username
            // 
            this.loadButton_username.Location = new System.Drawing.Point(416, 49);
            this.loadButton_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadButton_username.Name = "loadButton_username";
            this.loadButton_username.Size = new System.Drawing.Size(82, 22);
            this.loadButton_username.TabIndex = 5;
            this.loadButton_username.Text = "Load";
            this.loadButton_username.UseVisualStyleBackColor = true;
            this.loadButton_username.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_id
            // 
            this.combo_id.FormattingEnabled = true;
            this.combo_id.Items.AddRange(new object[] {
            "Username",
            "Card id"});
            this.combo_id.Location = new System.Drawing.Point(23, 17);
            this.combo_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_id.Name = "combo_id";
            this.combo_id.Size = new System.Drawing.Size(133, 23);
            this.combo_id.TabIndex = 7;
            // 
            // combo_product
            // 
            this.combo_product.FormattingEnabled = true;
            this.combo_product.Items.AddRange(new object[] {
            "A4BW",
            "A4CL"});
            this.combo_product.Location = new System.Drawing.Point(174, 207);
            this.combo_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_product.Name = "combo_product";
            this.combo_product.Size = new System.Drawing.Size(133, 23);
            this.combo_product.TabIndex = 8;
            // 
            // button_print
            // 
            this.button_print.Location = new System.Drawing.Point(416, 207);
            this.button_print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(82, 22);
            this.button_print.TabIndex = 9;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Card id";
            // 
            // photocopies_nb
            // 
            this.photocopies_nb.AutoSize = true;
            this.photocopies_nb.Location = new System.Drawing.Point(23, 175);
            this.photocopies_nb.Name = "photocopies_nb";
            this.photocopies_nb.Size = new System.Drawing.Size(90, 15);
            this.photocopies_nb.TabIndex = 11;
            this.photocopies_nb.Text = "Photocopies nb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product";
            // 
            // photocopies_in
            // 
            this.photocopies_in.Location = new System.Drawing.Point(174, 172);
            this.photocopies_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photocopies_in.Name = "photocopies_in";
            this.photocopies_in.Size = new System.Drawing.Size(110, 23);
            this.photocopies_in.TabIndex = 13;
            // 
            // card_id_in
            // 
            this.card_id_in.Location = new System.Drawing.Point(174, 134);
            this.card_id_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.card_id_in.Name = "card_id_in";
            this.card_id_in.Size = new System.Drawing.Size(110, 23);
            this.card_id_in.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 254);
            this.Controls.Add(this.card_id_in);
            this.Controls.Add(this.photocopies_in);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.photocopies_nb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.combo_product);
            this.Controls.Add(this.combo_id);
            this.Controls.Add(this.loadButton_username);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.quotaField);
            this.Controls.Add(this.amount_name);
            this.Controls.Add(this.idField);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.TextBox quotaField;
        private System.Windows.Forms.Label amount_name;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button loadButton_username;
        private System.Windows.Forms.ComboBox combo_id;
        private System.Windows.Forms.ComboBox combo_product;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label photocopies_nb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox photocopies_in;
        private System.Windows.Forms.TextBox card_id_in;
    }
}

