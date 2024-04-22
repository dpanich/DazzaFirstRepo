namespace GradeCalculator2
{
    partial class GradeCalculator2
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
            txtQuiz1 = new TextBox();
            txtQuiz2 = new TextBox();
            txtQuiz3 = new TextBox();
            txtMidterm = new TextBox();
            txtFinalExam = new TextBox();
            txtFinalPCT = new TextBox();
            txtFinalLTR = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblDroppedQuiz = new Label();
            SuspendLayout();
            // 
            // txtQuiz1
            // 
            txtQuiz1.Location = new Point(158, 71);
            txtQuiz1.Name = "txtQuiz1";
            txtQuiz1.Size = new Size(100, 23);
            txtQuiz1.TabIndex = 0;
            // 
            // txtQuiz2
            // 
            txtQuiz2.Location = new Point(158, 120);
            txtQuiz2.Name = "txtQuiz2";
            txtQuiz2.Size = new Size(100, 23);
            txtQuiz2.TabIndex = 1;
            // 
            // txtQuiz3
            // 
            txtQuiz3.Location = new Point(158, 169);
            txtQuiz3.Name = "txtQuiz3";
            txtQuiz3.Size = new Size(100, 23);
            txtQuiz3.TabIndex = 2;
            // 
            // txtMidterm
            // 
            txtMidterm.Location = new Point(158, 220);
            txtMidterm.Name = "txtMidterm";
            txtMidterm.Size = new Size(100, 23);
            txtMidterm.TabIndex = 3;
            // 
            // txtFinalExam
            // 
            txtFinalExam.Location = new Point(158, 278);
            txtFinalExam.Name = "txtFinalExam";
            txtFinalExam.Size = new Size(100, 23);
            txtFinalExam.TabIndex = 4;
            // 
            // txtFinalPCT
            // 
            txtFinalPCT.Location = new Point(541, 169);
            txtFinalPCT.Name = "txtFinalPCT";
            txtFinalPCT.ReadOnly = true;
            txtFinalPCT.Size = new Size(100, 23);
            txtFinalPCT.TabIndex = 5;
            txtFinalPCT.TabStop = false;
            // 
            // txtFinalLTR
            // 
            txtFinalLTR.Location = new Point(541, 220);
            txtFinalLTR.Name = "txtFinalLTR";
            txtFinalLTR.ReadOnly = true;
            txtFinalLTR.Size = new Size(100, 23);
            txtFinalLTR.TabIndex = 6;
            txtFinalLTR.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(104, 342);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "C&alculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(252, 342);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(664, 342);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 71);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 10;
            label1.Text = "Quiz 1 Result";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 123);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 11;
            label2.Text = "Quiz 2 Result";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 172);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 12;
            label3.Text = "Quiz 3 Result";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 223);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 13;
            label4.Text = "Midterm Exam Result";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 286);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 14;
            label5.Text = "Final Exam Result";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(387, 177);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 15;
            label6.Text = "Final Grade Percent";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(387, 223);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 16;
            label7.Text = "Final Grade Letter";
            // 
            // lblDroppedQuiz
            // 
            lblDroppedQuiz.AutoSize = true;
            lblDroppedQuiz.Location = new Point(387, 278);
            lblDroppedQuiz.Name = "lblDroppedQuiz";
            lblDroppedQuiz.Size = new Size(360, 15);
            lblDroppedQuiz.TabIndex = 17;
            lblDroppedQuiz.Text = "The lowest quiz grade will not be used to calculate your final grade.";
            // 
            // GradeCalculator2
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDroppedQuiz);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtFinalLTR);
            Controls.Add(txtFinalPCT);
            Controls.Add(txtFinalExam);
            Controls.Add(txtMidterm);
            Controls.Add(txtQuiz3);
            Controls.Add(txtQuiz2);
            Controls.Add(txtQuiz1);
            Name = "GradeCalculator2";
            Text = "GradeCalculator2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuiz1;
        private TextBox txtQuiz2;
        private TextBox txtQuiz3;
        private TextBox txtMidterm;
        private TextBox txtFinalExam;
        private TextBox txtFinalPCT;
        private TextBox txtFinalLTR;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblDroppedQuiz;
    }
}
