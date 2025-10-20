// a class to hold the results of an InputValidator int object

namespace CIS_207_Project_5_Student_Report_Card
{
    internal class ValidationResultInt : ValidationResultBase
    {
        private int value;

        public int Value                                                        // the validated value
        {
            get => value;
            set => this.value = value;
        }

        public ValidationResultInt(string _errorMessage, string _errorTitle)    // constructor for an error result
        {
            this.IsError = true;
            this.ErrorMessage = _errorMessage;
            this.ErrorTitle = _errorTitle;
        }

        public ValidationResultInt(int _value)                                  // constructor for a successful result
        {
            IsError = false;
            Value = _value;
        }
    }

}


