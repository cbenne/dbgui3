namespace dbgui3
{
    partial class saleswizard
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
            this.CustomerIDEntry = new System.Windows.Forms.TextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.PartIDLabel = new System.Windows.Forms.Label();
            this.PartIDEntry = new System.Windows.Forms.TextBox();
            this.ReceiptIDLabel = new System.Windows.Forms.Label();
            this.ReceiptIDEntry = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceEntry = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.QuantityEntry = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateEntry = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerIDEntry
            // 
            this.CustomerIDEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerIDEntry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDEntry.Location = new System.Drawing.Point(8, 100);
            this.CustomerIDEntry.Name = "CustomerIDEntry";
            this.CustomerIDEntry.Size = new System.Drawing.Size(208, 32);
            this.CustomerIDEntry.TabIndex = 0;
            this.CustomerIDEntry.TextChanged += new System.EventHandler(this.CustomerIDEntry_TextChanged);
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLabel.Location = new System.Drawing.Point(4, 72);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(116, 25);
            this.CustomerIDLabel.TabIndex = 1;
            this.CustomerIDLabel.Text = "Customer ID";
            this.CustomerIDLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PartIDLabel
            // 
            this.PartIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PartIDLabel.AutoSize = true;
            this.PartIDLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartIDLabel.Location = new System.Drawing.Point(8, 135);
            this.PartIDLabel.Name = "PartIDLabel";
            this.PartIDLabel.Size = new System.Drawing.Size(68, 25);
            this.PartIDLabel.TabIndex = 3;
            this.PartIDLabel.Text = "Part ID";
            this.PartIDLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // PartIDEntry
            // 
            this.PartIDEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PartIDEntry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartIDEntry.Location = new System.Drawing.Point(8, 163);
            this.PartIDEntry.Name = "PartIDEntry";
            this.PartIDEntry.Size = new System.Drawing.Size(208, 32);
            this.PartIDEntry.TabIndex = 2;
            this.PartIDEntry.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ReceiptIDLabel
            // 
            this.ReceiptIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReceiptIDLabel.AutoSize = true;
            this.ReceiptIDLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptIDLabel.Location = new System.Drawing.Point(8, 9);
            this.ReceiptIDLabel.Name = "ReceiptIDLabel";
            this.ReceiptIDLabel.Size = new System.Drawing.Size(96, 25);
            this.ReceiptIDLabel.TabIndex = 5;
            this.ReceiptIDLabel.Text = "Receipt ID";
            // 
            // ReceiptIDEntry
            // 
            this.ReceiptIDEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceiptIDEntry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptIDEntry.Location = new System.Drawing.Point(13, 37);
            this.ReceiptIDEntry.Name = "ReceiptIDEntry";
            this.ReceiptIDEntry.Size = new System.Drawing.Size(207, 32);
            this.ReceiptIDEntry.TabIndex = 4;
            this.ReceiptIDEntry.TextChanged += new System.EventHandler(this.ReceiptIDEntry_TextChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(8, 198);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(54, 25);
            this.PriceLabel.TabIndex = 7;
            this.PriceLabel.Text = "Price";
            // 
            // PriceEntry
            // 
            this.PriceEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceEntry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceEntry.Location = new System.Drawing.Point(9, 226);
            this.PriceEntry.Name = "PriceEntry";
            this.PriceEntry.Size = new System.Drawing.Size(207, 32);
            this.PriceEntry.TabIndex = 6;
            this.PriceEntry.TextChanged += new System.EventHandler(this.PriceEntry_TextChanged);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(8, 266);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(84, 25);
            this.QuantityLabel.TabIndex = 9;
            this.QuantityLabel.Text = "Quantity";
            // 
            // QuantityEntry
            // 
            this.QuantityEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityEntry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityEntry.Location = new System.Drawing.Point(9, 294);
            this.QuantityEntry.Name = "QuantityEntry";
            this.QuantityEntry.Size = new System.Drawing.Size(207, 32);
            this.QuantityEntry.TabIndex = 8;
            this.QuantityEntry.TextChanged += new System.EventHandler(this.QuantityEntry_TextChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(8, 328);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(51, 25);
            this.DateLabel.TabIndex = 11;
            this.DateLabel.Text = "Date";
            // 
            // DateEntry
            // 
            this.DateEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DateEntry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEntry.Location = new System.Drawing.Point(9, 356);
            this.DateEntry.Name = "DateEntry";
            this.DateEntry.Size = new System.Drawing.Size(207, 32);
            this.DateEntry.TabIndex = 10;
            this.DateEntry.TextChanged += new System.EventHandler(this.DateEntry_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SubmitButton.Enabled = false;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(9, 394);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(99, 43);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(117, 394);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(103, 43);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // saleswizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 449);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DateEntry);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.QuantityEntry);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.PriceEntry);
            this.Controls.Add(this.ReceiptIDLabel);
            this.Controls.Add(this.ReceiptIDEntry);
            this.Controls.Add(this.PartIDLabel);
            this.Controls.Add(this.PartIDEntry);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.CustomerIDEntry);
            this.MinimumSize = new System.Drawing.Size(253, 488);
            this.Name = "saleswizard";
            this.Text = "Sales Wizard";
            this.Load += new System.EventHandler(this.saleswizard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerIDEntry;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label PartIDLabel;
        private System.Windows.Forms.TextBox PartIDEntry;
        private System.Windows.Forms.Label ReceiptIDLabel;
        private System.Windows.Forms.TextBox ReceiptIDEntry;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceEntry;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox QuantityEntry;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox DateEntry;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
    }
}