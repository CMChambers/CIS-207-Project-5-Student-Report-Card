// a class for a student object
// holds name and score info
// has methods to return calculated letter grade and pass/fail status

namespace CIS_207_Project_5_Student_Report_Card
{
    internal class Student
    {
        private const int PASSING_SCORE_MINIMUM = 70;   // constant for the minimum for passing status
        private const int LETTER_GRADE_A_MINIMUM = 90;  // constant for the minimum for letter grade A
        private const int LETTER_GRADE_B_MINIMUM = 80;  // constant for the minimum for letter grade B
        private const int LETTER_GRADE_C_MINIMUM = 70;  // constant for the minimum for letter grade C
        private const int LETTER_GRADE_D_MINIMUM = 60;  // constant for the minimum for letter grade D
        private string name = "";
        private int score = 0;

        public string Name                              // the student name
        {
            get { return name; }
            set { name = value; }
        }
        public int Score                                // the student score
        {
            get { return score; }
            set
            {
                if (value < 0) value = 0;               // clamp value at min
                if (value > 100) value = 100;           // clamp value at max
                score = value;
            }
        }

        public Student(string _name, int _score)        // constructor
        {
            Name = _name;
            Score = _score;
        }


        public string GetLetterGrade()                  // returns the letter grade equivalent of the score
        {
            string letterGrade;

            switch (score)                              // switch on the value of score
            {
                case >= LETTER_GRADE_A_MINIMUM:
                    letterGrade = "A";
                    break;
                case >= LETTER_GRADE_B_MINIMUM:
                    letterGrade = "B";
                    break;
                case >= LETTER_GRADE_C_MINIMUM:
                    letterGrade = "C";
                    break;
                case >= LETTER_GRADE_D_MINIMUM:
                    letterGrade = "D";
                    break;
                default:
                    letterGrade = "F";
                    break;
            }

            return letterGrade;
        }

        internal string GetGradeStatus()                // returns pass/fail status based on score
        {
            if (score >= PASSING_SCORE_MINIMUM)
            { return "Pass"; }
            return "Fail";
        }
    }
}
