﻿namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public char Sex { get; private set; }
        public void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }

        }
        public void AddGrade(int grade)
        {
            float gradeInFloat = (float)grade;
            this.AddGrade(gradeInFloat);

        }

        public void AddGrade(double grade)
        {
            float gradeInFloat = (float)grade;
            this.AddGrade(gradeInFloat);

        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }

        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;

                case "-6":
                case "6-":
                    this.AddGrade(95);
                    break;

                case "5+":
                case "+5":
                    this.AddGrade(85);
                    break;

                case "5":
                    this.AddGrade(80);
                    break;

                case "5-":
                case "-5":
                    this.AddGrade(75);
                    break;

                case "4+":
                case "+4":
                    this.AddGrade(65);
                    break;

                case "4":
                    this.AddGrade(60);
                    break;

                case "4-":
                case "-4":
                    this.AddGrade(55);
                    break;

                case "3+":
                case "+3":
                    this.AddGrade(45);
                    break;

                case "3":
                    this.AddGrade(40);
                    break;

                case "3-":
                case "-3":
                    this.AddGrade(35);
                    break;

                case "2+":
                case "+2":
                    this.AddGrade(25);
                    break;

                case "2":
                    this.AddGrade(20);
                    break;

                case "2-":
                case "-2":
                    this.AddGrade(15);
                    break;

                case "1+":
                case "+1":
                    this.AddGrade(5);
                    break;

                case "1":
                    this.AddGrade(0);
                    break;
                default:
                    throw new Exception("You can only use grades in range: 6, 6-,5+,5,4+,4,4-,3+,3,3-,2+,2,-2,1 ");


            }

        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.SumOfGrades = this.grades.Sum();

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var a when a >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var a when a >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;

            }

            return statistics;

        }
    }
}
