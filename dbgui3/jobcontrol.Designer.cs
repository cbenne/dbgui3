namespace dbgui3
{
    partial class jobcontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jobcontrol));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxSubmit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uxcompleted = new System.Windows.Forms.CheckBox();
            this.uxdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.uxProcessName = new System.Windows.Forms.ListBox();
            this.uxqty = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxJobID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxqty)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1125, 600);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.uxSubmit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 546);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1113, 48);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // uxSubmit
            // 
            this.uxSubmit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.uxSubmit.Enabled = false;
            this.uxSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.uxSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uxSubmit.ImageIndex = 2;
            this.uxSubmit.ImageList = this.imageList1;
            this.uxSubmit.Location = new System.Drawing.Point(890, 3);
            this.uxSubmit.Name = "uxSubmit";
            this.uxSubmit.Size = new System.Drawing.Size(220, 45);
            this.uxSubmit.TabIndex = 0;
            this.uxSubmit.Text = "Submit";
            this.uxSubmit.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "addicon.png");
            this.imageList1.Images.SetKeyName(1, "searchicon.png");
            this.imageList1.Images.SetKeyName(2, "submiticon.png");
            this.imageList1.Images.SetKeyName(3, "checkicon.png");
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1119, 534);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 91);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Part";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(315, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 91);
            this.panel3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 81);
            this.button2.TabIndex = 0;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uxcompleted);
            this.panel2.Controls.Add(this.uxdateTimePicker1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.uxProcessName);
            this.panel2.Controls.Add(this.uxqty);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.uxJobID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 299);
            this.panel2.TabIndex = 1;
            // 
            // uxcompleted
            // 
            this.uxcompleted.Appearance = System.Windows.Forms.Appearance.Button;
            this.uxcompleted.FlatAppearance.BorderSize = 2;
            this.uxcompleted.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.uxcompleted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.uxcompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxcompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxcompleted.ImageKey = "(none)";
            this.uxcompleted.ImageList = this.imageList1;
            this.uxcompleted.Location = new System.Drawing.Point(142, 162);
            this.uxcompleted.Name = "uxcompleted";
            this.uxcompleted.Size = new System.Drawing.Size(37, 35);
            this.uxcompleted.TabIndex = 11;
            this.uxcompleted.UseVisualStyleBackColor = true;
            this.uxcompleted.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // uxdateTimePicker1
            // 
            this.uxdateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxdateTimePicker1.Location = new System.Drawing.Point(144, 221);
            this.uxdateTimePicker1.Name = "uxdateTimePicker1";
            this.uxdateTimePicker1.Size = new System.Drawing.Size(309, 33);
            this.uxdateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date:";
            // 
            // uxProcessName
            // 
            this.uxProcessName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxProcessName.FormattingEnabled = true;
            this.uxProcessName.ItemHeight = 25;
            this.uxProcessName.Location = new System.Drawing.Point(144, 61);
            this.uxProcessName.Name = "uxProcessName";
            this.uxProcessName.Size = new System.Drawing.Size(433, 29);
            this.uxProcessName.TabIndex = 8;
            // 
            // uxqty
            // 
            this.uxqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxqty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxqty.Location = new System.Drawing.Point(144, 111);
            this.uxqty.Name = "uxqty";
            this.uxqty.Size = new System.Drawing.Size(86, 33);
            this.uxqty.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Completed: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Process Name:";
            // 
            // uxJobID
            // 
            this.uxJobID.Enabled = false;
            this.uxJobID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxJobID.Location = new System.Drawing.Point(144, 10);
            this.uxJobID.Name = "uxJobID";
            this.uxJobID.Size = new System.Drawing.Size(60, 33);
            this.uxJobID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job ID:";
            // 
            // jobcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "jobcontrol";
            this.Size = new System.Drawing.Size(1125, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxqty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button uxSubmit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker uxdateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox uxProcessName;
        private System.Windows.Forms.NumericUpDown uxqty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxJobID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox uxcompleted;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
    }
}
