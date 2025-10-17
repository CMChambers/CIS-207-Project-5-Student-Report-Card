// a class to hold the results of an InputValidator string object

namespace CIS_207_Project_5_Student_Report_Card
{
    internal class ValidationResultString
    {
        private bool isError;
        private string errorMessage = string.Empty;
        private string errorTitle = string.Empty;
        private string value;

        public bool IsError                                                     // flag to show successful validation
        { get => isError; set => isError = value; }
        public string ErrorMessage                                              // the error message for an unsuccessful validation
        { get => errorMessage; set => errorMessage = value; }
        public string ErrorTitle                                                // the error message box title for unsuccessful validation
        { get => errorTitle; set => errorTitle = value; }
        public string Value                                                     // the validated value
        { get => value; set => this.value = value; }

        public ValidationResultString(string _errorMessage, string _errorTitle) // constructor for an error result
        {
            this.IsError = true;
            this.ErrorMessage = _errorMessage;
            this.ErrorTitle = _errorTitle;
        }

        public ValidationResultString(string _value)                            // constructor for a successful result
        {
            IsError = false;
            Value = _value;
        }

    }
}
