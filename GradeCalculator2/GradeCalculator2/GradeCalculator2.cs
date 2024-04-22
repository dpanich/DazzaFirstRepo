namespace GradeCalculator2
{
    /*
        *App to calculate final course grade based on input of assigned grades from
        *three quizes, one midterm, and one final exam. The lowest assigned quiz grade is dropped 
        *from the final course grade calculation while the remaining two quiz grades account 
        *for 30% of the final grade. The midterm and final exam grades account for 30% and 40% of
        *the final course grade respectively.
        *Percent grade converted to letter grade based on following criteria:
        *>=90% assigned A
        *<90 and >=80% assigned B
        *<80 and >=70% assigned C
        *,70 and >=60% assigned D
        *<60 assigned F
        *
        *Author: Darrell Panich
        *Date: April 2024
        */

    public partial class GradeCalculator2 : Form
    {
        public GradeCalculator2()
        {
            InitializeComponent();
        }
        //Calculate button action
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variables
            const decimal QUIZ_PCT = 0.30m;
            const decimal MIDTERM_PCT = 0.30m;
            const decimal FINAL_PCT = 0.40m;
            int quiz1Result;
            int quiz2Result;
            int quiz3Result;
            int midtermResult;
            int finalExamResult;
            int lowestQuizResult;
            int top2QuizResults;
            decimal finalGradePCT;
            string finalGradeLTR;

            //obtain grades from user input

            quiz1Result = Convert.ToInt32(txtQuiz1.Text);
            quiz2Result = Convert.ToInt32(txtQuiz2.Text);
            quiz3Result = Convert.ToInt32(txtQuiz3.Text);
            midtermResult = Convert.ToInt32(txtMidterm.Text);
            finalExamResult = Convert.ToInt32(txtFinalExam.Text);


            //Determine lowest quiz
            lowestQuizResult = quiz1Result;
            if (quiz2Result < lowestQuizResult)
            {
                lowestQuizResult = quiz2Result;
            }
            if (quiz3Result < lowestQuizResult)
            {
                lowestQuizResult = quiz3Result;
            }
            

            //Define two highest quiz

            top2QuizResults = (quiz3Result + quiz2Result + quiz1Result) - lowestQuizResult;

            //Statement of which quiz is dropped

            lblDroppedQuiz.Text = "The lowest quiz grade of " + lowestQuizResult.ToString() + " was not used to calculate your final grade.";

            //Calculate final grade percent

            finalGradePCT = ((top2QuizResults/2) * QUIZ_PCT) + (midtermResult * MIDTERM_PCT) + (finalExamResult * FINAL_PCT);

            //display final grade percent

            txtFinalPCT.Text = finalGradePCT.ToString("f2");

            //Determine final grade letter
            finalGradeLTR = "";

            if (finalGradePCT >= 90m)
                finalGradeLTR = "A";
            
            else if (finalGradePCT < 90m && finalGradePCT >= 80m )
            {
                finalGradeLTR = "B";
            }

            else if (finalGradePCT <80m && finalGradePCT >= 70m)
            {
                finalGradeLTR = "C";
            }
            else if (finalGradePCT < 70m && finalGradePCT >= 60m)
            {
                finalGradeLTR = "D";
            }
            else if (finalGradePCT < 60m)
            {
                finalGradeLTR = "F";
            }

            //display final grade letter

            txtFinalLTR.Text = finalGradeLTR.ToString();

        }

        //Clear button action
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFinalExam.Text = string.Empty;
            txtMidterm.Text = string.Empty;
            txtQuiz1.Text = string.Empty;
            txtQuiz2.Text = string.Empty;
            txtQuiz3.Text = string.Empty;
            txtFinalPCT.Text = string.Empty;
            txtFinalLTR.Text = string.Empty;
            lblDroppedQuiz.Text = "The lowest quiz grade will not be used to calculate your final grade.";
            txtQuiz1.Focus();
        }
        //exit button action
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
