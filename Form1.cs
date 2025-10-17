// Projects 5: Student Report Card
// Author: Chad Chambers
// Date: 13 Oct 2025
// Description: a simple gui app to take in a student name and score
//              and show the corresponding letter grad, a pass/fail status, and a summary of the provided info

namespace CIS_207_Project_5_Student_Report_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowLetterGrade_Click(object sender, EventArgs e)                       // handles show letter grade button click
        {
            ClearFormResults();

            ValidationResultString validatedName = InputValidator.ValidateString(txtName.Text); // attempt to validate the text input from the name text box
            ValidationResultInt validatedScore = InputValidator.ValidateInt(txtScore.Text);     // attempt to validate the text input from the score text box
            if (ValidatedError(validatedName, validatedScore)) { return; }                      // if validation has an error, return early

            Student student = new(validatedName.Value, validatedScore.Value);                   // create new student object- pass in name and validated score values

            ShowPassFailStatus(student);                                                        // call method to show pass/fail status
            ShowLetterGrade(student);                                                           // call method to show letter grade
            ShowSummary(student);                                                               // call method to show summary of student info
        }

        private void ClearFormResults()                                                         // clears all labels and text boxes
        {
            lblLetterGrade.Text = string.Empty;
            lblPassFailStatus.Text = string.Empty;
            lblSummaryName.Text = string.Empty;
            lblSummaryScore.Text = string.Empty;
            lblSummaryLetterGrade.Text = string.Empty;
            lblSummaryPassFailStatus.Text = string.Empty;
        }

        private bool ValidatedError(ValidationResultString validatedName, ValidationResultInt validatedScore) // handles errors in validations
        {
            if (validatedName.IsError)                                                          // if the attempt to validate the name has an error
            {
                MessageBox.Show(validatedName.ErrorMessage, validatedName.ErrorTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);              // show that error
                txtName.Focus();                                                                // put cursor focus on the name text box
                return true;
            }
            if (validatedScore.IsError)                                                         // if the attempt to validate the score has an error
            {
                MessageBox.Show(validatedScore.ErrorMessage, validatedScore.ErrorTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);              // show that error
                txtScore.Focus();                                                               // put cursor focus on the name text box
                return true;
            }
            return false;                                                                       // if no error, return false
        }

        private void ShowSummary(Student _student)                                              // populates summary labels with student info
        {
            lblSummaryName.Text = _student.Name;
            lblSummaryScore.Text = _student.Score.ToString();
            lblSummaryLetterGrade.Text = _student.GetLetterGrade();
            lblSummaryPassFailStatus.Text = _student.GetGradeStatus();
        }

        private void ShowPassFailStatus(Student student)                                        // method to show pass/fail status
        { lblPassFailStatus.Text = student.GetGradeStatus(); }                                  // call method on student object to fill pass/fail label

        private void ShowLetterGrade(Student student)                                           // method to show letter grade
        { lblLetterGrade.Text = student.GetLetterGrade(); }                                     // call method on student object to fill letter grade label
    }
}

