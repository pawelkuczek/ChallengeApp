namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserGetsAndLosesGrades_ShouldReturnCorrectSum()
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