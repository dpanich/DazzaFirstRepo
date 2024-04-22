namespace PayCalculator2
{
    public partial class PayCalculator2 : Form
    {
        public PayCalculator2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const decimal WORK_WEEK = 37.5m; //37.5 hours in a regular work week
            const decimal OT_MOD = 1.5m;
            decimal totalHours; //user-entered hours worked
            decimal regRate; //user-entered rate of pay
            decimal regHours; //calculated straight time hours (max=WORK_WEEK)
            decimal OTHours; //calculated overtime hours (hours-WORK_WEEK)
            decimal OTRate; //calculated OT rate (OT_MOD * regRate)
            decimal regPay; //calculated regular pay
            decimal OTPay;  //calculated OT pay
            decimal netPay;  //calculated net pay


            //get hours and rate

            totalHours = Convert.ToDecimal(txtHours.Text);
            regRate = Convert.ToDecimal(txtRate.Text);

            //determne amount of regular and overtime hours worked
            regHours = totalHours;
            OTHours = 0;
            if (totalHours > WORK_WEEK)  //Overtime (>37.5hours) worked
            {
                regHours = WORK_WEEK;
                OTHours = totalHours - WORK_WEEK;
            }
            
            //determine OT rate
            OTRate = OT_MOD * regRate;

            //Calculate regular pay
            regPay = regHours * regRate;

            //Calculate OT pay
            OTPay = OTHours * OTRate;

            //Calculate net pay
            netPay = regPay + OTPay;
            
            //display regular hours

            txtRegHours.Text = regHours.ToString("f2");


            //display regular pay
            txtRegPay.Text = regPay.ToString("c");

            //dispaly OT hours
            txtOTHours.Text = OTHours.ToString("f2");

            //dispaly OT pay
            txtOTPay.Text = OTPay.ToString("c");

            //Display total pay
            txtTotalPay.Text = netPay.ToString("f2");


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHours.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtHours.Focus();
            txtOTHours.Text= string.Empty;
            txtOTPay.Text= string.Empty;    
            txtTotalPay.Text= string.Empty;
            txtRegHours.Text= string.Empty; 
            txtRegPay.Text= string.Empty;   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
