namespace _04._16.Windows
{
    partial class mainWindow
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
            this.invoiceBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // invoiceBtn
            // 
            this.invoiceBtn.Location = new System.Drawing.Point(138, 157);
            this.invoiceBtn.Name = "invoiceBtn";
            this.invoiceBtn.Size = new System.Drawing.Size(75, 41);
            this.invoiceBtn.TabIndex = 0;
            this.invoiceBtn.Text = "Invoice";
            this.invoiceBtn.UseVisualStyleBackColor = true;
            this.invoiceBtn.Click += new System.EventHandler(this.invoiceBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.Location = new System.Drawing.Point(522, 157);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(75, 41);
            this.productBtn.TabIndex = 0;
            this.productBtn.Text = "Product";
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productBtn);
            this.Controls.Add(this.invoiceBtn);
            this.Name = "mainWindow";
            this.Text = "mainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button invoiceBtn;
        private System.Windows.Forms.Button productBtn;
    }
}