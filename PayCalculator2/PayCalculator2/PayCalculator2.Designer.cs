namespace PayCalculator2
{
    partial class PayCalculator2
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
            txtHours = new TextBox();
            txtRate = new TextBox();
            txtRegHours = new TextBox();
            txtRegPay = new TextBox();
            txtOTHours = new TextBox();
            txtOTPay = new TextBox();
            txtTotalPay = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtHours
            // 
            txtHours.Location = new Point(210, 147);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(100, 23);
            txtHours.TabIndex = 0;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(210, 202);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 1;
            // 
            // txtRegHours
            // 
            txtRegHours.Location = new Point(532, 147);
            txtRegHours.Name = "txtRegHours";
            txtRegHours.ReadOnly = true;
            txtRegHours.Size = new Size(100, 23);
            txtRegHours.TabIndex = 2;
            txtRegHours.TabStop = false;
            // 
            // txtRegPay
            // 
            txtRegPay.Location = new Point(532, 202);
            txtRegPay.Name = "txtRegPay";
            txtRegPay.ReadOnly = true;
            txtRegPay.Size = new Size(100, 23);
            txtRegPay.TabIndex = 3;
            txtRegPay.TabStop = false;
            // 
            // txtOTHours
            // 
            txtOTHours.Location = new Point(532, 261);
            txtOTHours.Name = "txtOTHours";
            txtOTHours.ReadOnly = true;
            txtOTHours.Size = new Size(100, 23);
            txtOTHours.TabIndex = 4;
            txtOTHours.TabStop = false;
            // 
            // txtOTPay
            // 
            txtOTPay.Location = new Point(532, 318);
            txtOTPay.Name = "txtOTPay";
            txtOTPay.ReadOnly = true;
            txtOTPay.Size = new Size(100, 23);
            txtOTPay.TabIndex = 5;
            txtOTPay.TabStop = false;
            // 
            // txtTotalPay
            // 
            txtTotalPay.Location = new Point(532, 381);
            txtTotalPay.Name = "txtTotalPay";
            txtTotalPay.ReadOnly = true;
            txtTotalPay.Size = new Size(100, 23);
            txtTotalPay.TabIndex = 6;
            txtTotalPay.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(131, 264);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "C&alculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(131, 317);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(713, 381);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // PayCalculator2
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotalPay);
            Controls.Add(txtOTPay);
            Controls.Add(txtOTHours);
            Controls.Add(txtRegPay);
            Controls.Add(txtRegHours);
            Controls.Add(txtRate);
            Controls.Add(txtHours);
            Name = "PayCalculator2";
            Text = "PayCalculator2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHours;
        private TextBox txtRate;
        private TextBox txtRegHours;
        private TextBox txtRegPay;
        private TextBox txtOTHours;
        private TextBox txtOTPay;
        private TextBox txtTotalPay;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
