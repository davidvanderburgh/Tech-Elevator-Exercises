using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int TotalMarks { get; set; }
        public int PossibleMarks { get; }
        public string SubmitterName { get; }
        public string LetterGrade
        {
            get
            {
                double percentGrade = 100*(double)TotalMarks / (double)PossibleMarks;

                if (percentGrade >= 90)
                {
                    return "A";
                }
                else if (percentGrade >= 80)
                {
                    return "B";
                }
                else if (percentGrade >= 70)
                {
                    return "C";
                }
                else if (percentGrade >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }

        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
        }
    }
}
