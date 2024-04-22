namespace Payroll2
{
    partial class frmPayroll2
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
            txtEmployeeName = new TextBox();
            txtHours = new TextBox();
            txtRate = new TextBox();
            txtEmployeePay = new TextBox();
            txtEmployeeCount = new TextBox();
            txtTotalPayroll = new TextBox();
            btnAddPayroll = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lstPayroll = new ListBox();
            grpNewEmployee = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            grpNewEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(151, 31);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(229, 23);
            txtEmployeeName.TabIndex = 0;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(151, 70);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(100, 23);
            txtHours.TabIndex = 1;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(151, 115);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 2;
            // 
            // txtEmployeePay
            // 
            txtEmployeePay.Location = new Point(252, 225);
            txtEmployeePay.Name = "txtEmployeePay";
            txtEmployeePay.ReadOnly = true;
            txtEmployeePay.Size = new Size(100, 23);
            txtEmployeePay.TabIndex = 3;
            txtEmployeePay.TabStop = false;
            // 
            // txtEmployeeCount
            // 
            txtEmployeeCount.Location = new Point(182, 388);
            txtEmployeeCount.Name = "txtEmployeeCount";
            txtEmployeeCount.ReadOnly = true;
            txtEmployeeCount.Size = new Size(100, 23);
            txtEmployeeCount.TabIndex = 4;
            txtEmployeeCount.TabStop = false;
            // 
            // txtTotalPayroll
            // 
            txtTotalPayroll.Location = new Point(457, 388);
            txtTotalPayroll.Name = "txtTotalPayroll";
            txtTotalPayroll.ReadOnly = true;
            txtTotalPayroll.Size = new Size(100, 23);
            txtTotalPayroll.TabIndex = 5;
            txtTotalPayroll.TabStop = false;
            // 
            // btnAddPayroll
            // 
            btnAddPayroll.Location = new Point(62, 173);
            btnAddPayroll.Name = "btnAddPayroll";
            btnAddPayroll.Size = new Size(100, 23);
            btnAddPayroll.TabIndex = 6;
            btnAddPayroll.Text = "&Add to Payroll";
            btnAddPayroll.UseVisualStyleBackColor = true;
            btnAddPayroll.Click += btnAddPayroll_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(216, 173);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(677, 387);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lstPayroll
            // 
            lstPayroll.FormattingEnabled = true;
            lstPayroll.ItemHeight = 15;
            lstPayroll.Location = new Point(485, 90);
            lstPayroll.Name = "lstPayroll";
            lstPayroll.Size = new Size(267, 274);
            lstPayroll.TabIndex = 9;
            lstPayroll.TabStop = false;
            // 
            // grpNewEmployee
            // 
            grpNewEmployee.Controls.Add(label4);
            grpNewEmployee.Controls.Add(label3);
            grpNewEmployee.Controls.Add(label2);
            grpNewEmployee.Controls.Add(label1);
            grpNewEmployee.Controls.Add(btnClear);
            grpNewEmployee.Controls.Add(btnAddPayroll);
            grpNewEmployee.Controls.Add(txtEmployeePay);
            grpNewEmployee.Controls.Add(txtRate);
            grpNewEmployee.Controls.Add(txtHours);
            grpNewEmployee.Controls.Add(txtEmployeeName);
            grpNewEmployee.Location = new Point(30, 46);
            grpNewEmployee.Name = "grpNewEmployee";
            grpNewEmployee.Size = new Size(418, 281);
            grpNewEmployee.TabIndex = 10;
            grpNewEmployee.TabStop = false;
            grpNewEmployee.Text = "New Employee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 233);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 11;
            label4.Text = "Employee Pay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 118);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 10;
            label3.Text = "Hourly Rate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 73);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 9;
            label2.Text = "Hours Worked";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 8;
            label1.Text = "Employee Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 391);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 12;
            label5.Text = "# Employees";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(350, 395);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 13;
            label6.Text = "Total Payroll";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(485, 59);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 14;
            label7.Text = "Payroll";
            // 
            // frmPayroll2
            // 
            AcceptButton = btnAddPayroll;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(grpNewEmployee);
            Controls.Add(lstPayroll);
            Controls.Add(btnExit);
            Controls.Add(txtTotalPayroll);
            Controls.Add(txtEmployeeCount);
            Name = "frmPayroll2";
            Text = "PayrollCalculator2";
            grpNewEmployee.ResumeLayout(false);
            grpNewEmployee.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmployeeName;
        private TextBox txtHours;
        private TextBox txtRate;
        private TextBox txtEmployeePay;
        private TextBox txtEmployeeCount;
        private TextBox txtTotalPayroll;
        private Button btnAddPayroll;
        private Button btnClear;
        private Button btnExit;
        private ListBox lstPayroll;
        private GroupBox grpNewEmployee;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
