// a class to hold the results of an InputValidator string object

namespace CIS_207_Project_5_Student_Report_Card
{
    internal class ValidationResultString : ValidationResultBase
    {
        private string value;

        public string Value                                                     // the validated value
        {
            get => value;
            set => this.value = value;
        }

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
