using NUnit.Framework;
namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMaxGrade()
        {
            //arrange
            var employee = new Employee("Paweł", "Kuczek");
            employee.AddGrade(3);
            employee.AddGrade(4);
            employee.AddGrade(5);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(5, statistics.Max);

        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMinGrade()
        {
            //arrange
            var employee = new Employee("Paweł", "Kuczek");
            employee.AddGrade(3);
            employee.AddGrade(4);
            employee.AddGrade(5);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(3, statistics.Min);

        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverageGrade()
        {
            //arrange
            var employee = new Employee("Paweł", "Kuczek");
            employee.AddGrade(3);
            employee.AddGrade(4);
            employee.AddGrade(5);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(4.00, 2), Math.Round(statistics.Average, 2));

        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectSumOfGrades()
        {
            //arrange
            var employee = new Employee("Paweł", "Kuczek");
            employee.AddGrade(3);
            employee.AddGrade(4);
            employee.AddGrade(5);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(12, statistics.SumOfGrades);

        }
    }
}