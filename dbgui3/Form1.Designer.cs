namespace dbgui3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.uxHomeButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.uxPartsButton = new System.Windows.Forms.Button();
            this.uxJobsButton = new System.Windows.Forms.Button();
            this.uxSalesButton = new System.Windows.Forms.Button();
            this.uxOrdersButton = new System.Windows.Forms.Button();
            this.uxEmployeesButton = new System.Windows.Forms.Button();
            this.uxAnalysisButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homecontrol1 = new dbgui3.homecontrol();
            this.partscontrol1 = new dbgui3.partscontrol();
            this.jobcontrol1 = new dbgui3.jobcontrol();
            this.salescontrol1 = new dbgui3.salescontrol();
            this.ordercontrol1 = new dbgui3.ordercontrol();
            this.employeecontrol1 = new dbgui3.employeecontrol();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1215, 707);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.uxAnalysisButton);
            this.panel1.Controls.Add(this.uxEmployeesButton);
            this.panel1.Controls.Add(this.uxOrdersButton);
            this.panel1.Controls.Add(this.uxSalesButton);
            this.panel1.Controls.Add(this.uxJobsButton);
            this.panel1.Controls.Add(this.uxPartsButton);
            this.panel1.Controls.Add(this.uxHomeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 707);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Business\r\nInformation\r\nSystem";
            // 
            // uxHomeButton
            // 
            this.uxHomeButton.FlatAppearance.BorderSize = 0;
            this.uxHomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.uxHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxHomeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxHomeButton.ImageIndex = 2;
            this.uxHomeButton.ImageList = this.imageList1;
            this.uxHomeButton.Location = new System.Drawing.Point(12, 95);
            this.uxHomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxHomeButton.Name = "uxHomeButton";
            this.uxHomeButton.Size = new System.Drawing.Size(188, 55);
            this.uxHomeButton.TabIndex = 1;
            this.uxHomeButton.Text = "Home";
            this.uxHomeButton.UseVisualStyleBackColor = true;
            this.uxHomeButton.Click += new System.EventHandler(this.uxHomeButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dbicon.png");
            this.imageList1.Images.SetKeyName(1, "employeeicon.png");
            this.imageList1.Images.SetKeyName(2, "homeicon.png");
            this.imageList1.Images.SetKeyName(3, "jobicon.png");
            this.imageList1.Images.SetKeyName(4, "ordericon.png");
            this.imageList1.Images.SetKeyName(5, "particon.png");
            this.imageList1.Images.SetKeyName(6, "saleicon.png");
            // 
            // uxPartsButton
            // 
            this.uxPartsButton.FlatAppearance.BorderSize = 0;
            this.uxPartsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.uxPartsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxPartsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPartsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxPartsButton.ImageIndex = 5;
            this.uxPartsButton.ImageList = this.imageList1;
            this.uxPartsButton.Location = new System.Drawing.Point(12, 150);
            this.uxPartsButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxPartsButton.Name = "uxPartsButton";
            this.uxPartsButton.Size = new System.Drawing.Size(188, 55);
            this.uxPartsButton.TabIndex = 2;
            this.uxPartsButton.Text = "Parts";
            this.uxPartsButton.UseVisualStyleBackColor = true;
            this.uxPartsButton.Click += new System.EventHandler(this.uxPartsButton_Click);
            // 
            // uxJobsButton
            // 
            this.uxJobsButton.FlatAppearance.BorderSize = 0;
            this.uxJobsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.uxJobsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxJobsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxJobsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxJobsButton.ImageIndex = 3;
            this.uxJobsButton.ImageList = this.imageList1;
            this.uxJobsButton.Location = new System.Drawing.Point(12, 205);
            this.uxJobsButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxJobsButton.Name = "uxJobsButton";
            this.uxJobsButton.Size = new System.Drawing.Size(188, 55);
            this.uxJobsButton.TabIndex = 3;
            this.uxJobsButton.Text = "Jobs";
            this.uxJobsButton.UseVisualStyleBackColor = true;
            this.uxJobsButton.Click += new System.EventHandler(this.uxJobsButton_Click);
            // 
            // uxSalesButton
            // 
            this.uxSalesButton.FlatAppearance.BorderSize = 0;
            this.uxSalesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.uxSalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxSalesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSalesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxSalesButton.ImageIndex = 6;
            this.uxSalesButton.ImageList = this.imageList1;
            this.uxSalesButton.Location = new System.Drawing.Point(12, 260);
            this.uxSalesButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxSalesButton.Name = "uxSalesButton";
            this.uxSalesButton.Size = new System.Drawing.Size(188, 55);
            this.uxSalesButton.TabIndex = 4;
            this.uxSalesButton.Text = "Sales";
            this.uxSalesButton.UseVisualStyleBackColor = true;
            this.uxSalesButton.Click += new System.EventHandler(this.uxSalesButton_Click);
            // 
            // uxOrdersButton
            // 
            this.uxOrdersButton.FlatAppearance.BorderSize = 0;
            this.uxOrdersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.uxOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxOrdersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOrdersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxOrdersButton.ImageIndex = 4;
            this.uxOrdersButton.ImageList = this.imageList1;
            this.uxOrdersButton.Location = new System.Drawing.Point(12, 315);
            this.uxOrdersButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxOrdersButton.Name = "uxOrdersButton";
            this.uxOrdersButton.Size = new System.Drawing.Size(188, 55);
            this.uxOrdersButton.TabIndex = 5;
            this.uxOrdersButton.Text = "Orders";
            this.uxOrdersButton.UseVisualStyleBackColor = true;
            this.uxOrdersButton.Click += new System.EventHandler(this.uxOrdersButton_Click);
            // 
            // uxEmployeesButton
            // 
            this.uxEmployeesButton.FlatAppearance.BorderSize = 0;
            this.uxEmployeesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.uxEmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxEmployeesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEmployeesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxEmployeesButton.ImageIndex = 1;
            this.uxEmployeesButton.ImageList = this.imageList1;
            this.uxEmployeesButton.Location = new System.Drawing.Point(12, 370);
            this.uxEmployeesButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxEmployeesButton.Name = "uxEmployeesButton";
            this.uxEmployeesButton.Size = new System.Drawing.Size(188, 55);
            this.uxEmployeesButton.TabIndex = 6;
            this.uxEmployeesButton.Text = "Employees";
            this.uxEmployeesButton.UseVisualStyleBackColor = true;
            this.uxEmployeesButton.Click += new System.EventHandler(this.uxEmployeesButton_Click);
            // 
            // uxAnalysisButton
            // 
            this.uxAnalysisButton.FlatAppearance.BorderSize = 0;
            this.uxAnalysisButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.uxAnalysisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxAnalysisButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAnalysisButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxAnalysisButton.ImageIndex = 0;
            this.uxAnalysisButton.ImageList = this.imageList1;
            this.uxAnalysisButton.Location = new System.Drawing.Point(12, 425);
            this.uxAnalysisButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxAnalysisButton.Name = "uxAnalysisButton";
            this.uxAnalysisButton.Size = new System.Drawing.Size(188, 55);
            this.uxAnalysisButton.TabIndex = 7;
            this.uxAnalysisButton.Text = "Analysis";
            this.uxAnalysisButton.UseVisualStyleBackColor = true;
            this.uxAnalysisButton.Click += new System.EventHandler(this.uxAnalysisButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.employeecontrol1);
            this.panel2.Controls.Add(this.ordercontrol1);
            this.panel2.Controls.Add(this.salescontrol1);
            this.panel2.Controls.Add(this.jobcontrol1);
            this.panel2.Controls.Add(this.partscontrol1);
            this.panel2.Controls.Add(this.homecontrol1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(203, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 701);
            this.panel2.TabIndex = 1;
            // 
            // homecontrol1
            // 
            this.homecontrol1.AutoScroll = true;
            this.homecontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homecontrol1.Location = new System.Drawing.Point(0, 0);
            this.homecontrol1.Name = "homecontrol1";
            this.homecontrol1.Size = new System.Drawing.Size(1009, 701);
            this.homecontrol1.TabIndex = 0;
            // 
            // partscontrol1
            // 
            this.partscontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partscontrol1.Location = new System.Drawing.Point(0, 0);
            this.partscontrol1.Name = "partscontrol1";
            this.partscontrol1.Size = new System.Drawing.Size(1009, 701);
            this.partscontrol1.TabIndex = 1;
            // 
            // jobcontrol1
            // 
            this.jobcontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobcontrol1.Location = new System.Drawing.Point(0, 0);
            this.jobcontrol1.Name = "jobcontrol1";
            this.jobcontrol1.Size = new System.Drawing.Size(1009, 701);
            this.jobcontrol1.TabIndex = 2;
            // 
            // salescontrol1
            // 
            this.salescontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salescontrol1.Location = new System.Drawing.Point(0, 0);
            this.salescontrol1.Name = "salescontrol1";
            this.salescontrol1.Size = new System.Drawing.Size(1009, 701);
            this.salescontrol1.TabIndex = 3;
            // 
            // ordercontrol1
            // 
            this.ordercontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordercontrol1.Location = new System.Drawing.Point(0, 0);
            this.ordercontrol1.Name = "ordercontrol1";
            this.ordercontrol1.Size = new System.Drawing.Size(1009, 701);
            this.ordercontrol1.TabIndex = 4;
            // 
            // employeecontrol1
            // 
            this.employeecontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeecontrol1.Location = new System.Drawing.Point(0, 0);
            this.employeecontrol1.Name = "employeecontrol1";
            this.employeecontrol1.Size = new System.Drawing.Size(1009, 701);
            this.employeecontrol1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 707);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(650, 525);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxHomeButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button uxAnalysisButton;
        private System.Windows.Forms.Button uxEmployeesButton;
        private System.Windows.Forms.Button uxOrdersButton;
        private System.Windows.Forms.Button uxSalesButton;
        private System.Windows.Forms.Button uxJobsButton;
        private System.Windows.Forms.Button uxPartsButton;
        private System.Windows.Forms.Panel panel2;
        private partscontrol partscontrol1;
        private homecontrol homecontrol1;
        private jobcontrol jobcontrol1;
        private salescontrol salescontrol1;
        private ordercontrol ordercontrol1;
        private employeecontrol employeecontrol1;
    }
}

