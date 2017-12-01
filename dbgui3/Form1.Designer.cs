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
            this.uxAnalysisButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.uxEmployeesButton = new System.Windows.Forms.Button();
            this.uxOrdersButton = new System.Windows.Forms.Button();
            this.uxSalesButton = new System.Windows.Forms.Button();
            this.uxJobsButton = new System.Windows.Forms.Button();
            this.uxPartsButton = new System.Windows.Forms.Button();
            this.uxHomeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.employeecontrol1 = new dbgui3.employeecontrol();
            this.ordercontrol1 = new dbgui3.ordercontrol();
            this.salescontrol1 = new dbgui3.salescontrol();
            this.jobcontrol1 = new dbgui3.jobcontrol();
            this.partscontrol1 = new dbgui3.partscontrol();
            this.homecontrol1 = new dbgui3.homecontrol();
            this.analysiscontrol1 = new dbgui3.analysiscontrol();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1620, 870);
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
            this.panel1.Size = new System.Drawing.Size(267, 870);
            this.panel1.TabIndex = 0;
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
            this.uxAnalysisButton.Location = new System.Drawing.Point(16, 523);
            this.uxAnalysisButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxAnalysisButton.Name = "uxAnalysisButton";
            this.uxAnalysisButton.Size = new System.Drawing.Size(251, 68);
            this.uxAnalysisButton.TabIndex = 7;
            this.uxAnalysisButton.Text = "Analysis";
            this.uxAnalysisButton.UseVisualStyleBackColor = true;
            this.uxAnalysisButton.Click += new System.EventHandler(this.uxAnalysisButton_Click);
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
            // uxEmployeesButton
            // 
            this.uxEmployeesButton.FlatAppearance.BorderSize = 0;
            this.uxEmployeesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.uxEmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxEmployeesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEmployeesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxEmployeesButton.ImageIndex = 1;
            this.uxEmployeesButton.ImageList = this.imageList1;
            this.uxEmployeesButton.Location = new System.Drawing.Point(16, 455);
            this.uxEmployeesButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxEmployeesButton.Name = "uxEmployeesButton";
            this.uxEmployeesButton.Size = new System.Drawing.Size(251, 68);
            this.uxEmployeesButton.TabIndex = 6;
            this.uxEmployeesButton.Text = "Employees";
            this.uxEmployeesButton.UseVisualStyleBackColor = true;
            this.uxEmployeesButton.Click += new System.EventHandler(this.uxEmployeesButton_Click);
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
            this.uxOrdersButton.Location = new System.Drawing.Point(16, 388);
            this.uxOrdersButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxOrdersButton.Name = "uxOrdersButton";
            this.uxOrdersButton.Size = new System.Drawing.Size(251, 68);
            this.uxOrdersButton.TabIndex = 5;
            this.uxOrdersButton.Text = "Orders";
            this.uxOrdersButton.UseVisualStyleBackColor = true;
            this.uxOrdersButton.Click += new System.EventHandler(this.uxOrdersButton_Click);
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
            this.uxSalesButton.Location = new System.Drawing.Point(16, 320);
            this.uxSalesButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxSalesButton.Name = "uxSalesButton";
            this.uxSalesButton.Size = new System.Drawing.Size(251, 68);
            this.uxSalesButton.TabIndex = 4;
            this.uxSalesButton.Text = "Sales";
            this.uxSalesButton.UseVisualStyleBackColor = true;
            this.uxSalesButton.Click += new System.EventHandler(this.uxSalesButton_Click);
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
            this.uxJobsButton.Location = new System.Drawing.Point(16, 252);
            this.uxJobsButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxJobsButton.Name = "uxJobsButton";
            this.uxJobsButton.Size = new System.Drawing.Size(251, 68);
            this.uxJobsButton.TabIndex = 3;
            this.uxJobsButton.Text = "Jobs";
            this.uxJobsButton.UseVisualStyleBackColor = true;
            this.uxJobsButton.Click += new System.EventHandler(this.uxJobsButton_Click);
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
            this.uxPartsButton.Location = new System.Drawing.Point(16, 185);
            this.uxPartsButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxPartsButton.Name = "uxPartsButton";
            this.uxPartsButton.Size = new System.Drawing.Size(251, 68);
            this.uxPartsButton.TabIndex = 2;
            this.uxPartsButton.Text = "Parts";
            this.uxPartsButton.UseVisualStyleBackColor = true;
            this.uxPartsButton.Click += new System.EventHandler(this.uxPartsButton_Click);
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
            this.uxHomeButton.Location = new System.Drawing.Point(16, 117);
            this.uxHomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.uxHomeButton.Name = "uxHomeButton";
            this.uxHomeButton.Size = new System.Drawing.Size(251, 68);
            this.uxHomeButton.TabIndex = 1;
            this.uxHomeButton.Text = "Home";
            this.uxHomeButton.UseVisualStyleBackColor = true;
            this.uxHomeButton.Click += new System.EventHandler(this.uxHomeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Business\r\nInformation\r\nSystem";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.analysiscontrol1);
            this.panel2.Controls.Add(this.employeecontrol1);
            this.panel2.Controls.Add(this.ordercontrol1);
            this.panel2.Controls.Add(this.salescontrol1);
            this.panel2.Controls.Add(this.jobcontrol1);
            this.panel2.Controls.Add(this.partscontrol1);
            this.panel2.Controls.Add(this.homecontrol1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(271, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1345, 862);
            this.panel2.TabIndex = 1;
            // 
            // employeecontrol1
            // 
            this.employeecontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeecontrol1.Location = new System.Drawing.Point(0, 0);
            this.employeecontrol1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.employeecontrol1.Name = "employeecontrol1";
            this.employeecontrol1.Size = new System.Drawing.Size(1345, 862);
            this.employeecontrol1.TabIndex = 5;
            // 
            // ordercontrol1
            // 
            this.ordercontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordercontrol1.Location = new System.Drawing.Point(0, 0);
            this.ordercontrol1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ordercontrol1.Name = "ordercontrol1";
            this.ordercontrol1.Size = new System.Drawing.Size(1345, 862);
            this.ordercontrol1.TabIndex = 4;
            // 
            // salescontrol1
            // 
            this.salescontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salescontrol1.Location = new System.Drawing.Point(0, 0);
            this.salescontrol1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.salescontrol1.Name = "salescontrol1";
            this.salescontrol1.Size = new System.Drawing.Size(1345, 862);
            this.salescontrol1.TabIndex = 3;
            // 
            // jobcontrol1
            // 
            this.jobcontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobcontrol1.Location = new System.Drawing.Point(0, 0);
            this.jobcontrol1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.jobcontrol1.Name = "jobcontrol1";
            this.jobcontrol1.Size = new System.Drawing.Size(1345, 862);
            this.jobcontrol1.TabIndex = 2;
            // 
            // partscontrol1
            // 
            this.partscontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partscontrol1.Location = new System.Drawing.Point(0, 0);
            this.partscontrol1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.partscontrol1.Name = "partscontrol1";
            this.partscontrol1.Size = new System.Drawing.Size(1345, 862);
            this.partscontrol1.TabIndex = 1;
            // 
            // homecontrol1
            // 
            this.homecontrol1.AutoScroll = true;
            this.homecontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homecontrol1.Location = new System.Drawing.Point(0, 0);
            this.homecontrol1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.homecontrol1.Name = "homecontrol1";
            this.homecontrol1.Size = new System.Drawing.Size(1345, 862);
            this.homecontrol1.TabIndex = 0;
            // 
            // analysiscontrol1
            // 
            this.analysiscontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analysiscontrol1.Location = new System.Drawing.Point(0, 0);
            this.analysiscontrol1.Name = "analysiscontrol1";
            this.analysiscontrol1.Size = new System.Drawing.Size(1345, 862);
            this.analysiscontrol1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 870);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(861, 635);
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
        private analysiscontrol analysiscontrol1;
    }
}

