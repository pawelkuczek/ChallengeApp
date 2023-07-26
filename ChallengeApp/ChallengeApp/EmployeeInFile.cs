namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {

        private const string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInFile(string name, string surname, char sex) : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("Invalid grade value");

            }

        }

        public override void AddGrade(char grade)
        {

            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }



        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String in not float");
            }
        }

        public override void AddGrade(int grade)
        {
            float gradeInFloat = (float)grade;
            this.AddGrade(gradeInFloat);
        }

        public override void AddGrade(double grade)
        {
            float gradeInFloat = (float)grade;
            this.AddGrade(gradeInFloat);
        }


        public override Statistics GetStatistics()

        {
            var statistics = new Statistics();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        statistics.AddGrade(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return statistics;
        }
    }
}
