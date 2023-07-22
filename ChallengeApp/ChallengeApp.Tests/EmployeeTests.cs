using NUnit.Framework;
namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeGetsGrades_ShouldReturnCorrectPositiveResult()
        {
            //arrange
            var user = new Employee("Marek", "Kolano", 24);
            user.AddGrade(10);
            user.AddGrade(9);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(19, result);

        }

        [Test]
        public void WhenEmployeeLosesGrades_ShouldReturnCorrectNegativeResult()
        {
            //arrange
            var user = new Employee("Marek", "Kolano", 24);
            user.SubtractGrade(7);
            user.SubtractGrade(6);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(-13, result);

        }
        [Test]
        public void WhenEmployeeGetsAndLosesGrades_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new Employee("Marek", "Kolano", 24);
            user.AddGrade(5);
            user.AddGrade(8);
            user.SubtractGrade(3);
            user.AddGrade(6);
            user.SubtractGrade(4);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(12, result);

        }
    }
}