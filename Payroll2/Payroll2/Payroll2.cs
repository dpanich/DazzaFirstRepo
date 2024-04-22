namespace Payroll2
{
    public partial class frmPayroll2 : Form
    {
        //declare constants and variables at form level


        //create parallel arrays to store employee names and pay


        public frmPayroll2()
        {
            InitializeComponent();
        }
        
        //Obtain uesr-entered values


        //Need to include methods to validate user-entered data


        //Calculate employee pay on tab from txtRate field


        

        private void btnAddPayroll_Click(object sender, EventArgs e)
        {
           //data is validated and added to arrays
            
            //add employee and employee pay to lstPayroll


            //increase count on txtEmployeeCount



            //increase total on txtTotalPayroll


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all new employee fields and return focus to Employee name field

            txtEmployeeName.Text = string.Empty;
            txtHours.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtEmployeePay.Text = string.Empty;
            txtEmployeeName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
