using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        //Test klas (typy referencyjne)
        public void WhenComparingDifferentClassInstancesWithTheSameProperties_ShouldReturnTheyAreNotEqual()
        {
            //arrange
            var employee1 = new Employee("Paweł", "Puszka");
            var employee2 = new Employee("Paweł", "Puszka");
            //act

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        //Test stringów (hybryda typów)
        public void WhenComparingTwoTheSameStrings_ShouldReturnTheyAreEqual()
        {
            //arrange
            var name1 = "Marek";
            var name2 = "Marek";
            //act

            //assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        //Test intów (typ wartościowy)
        public void WhenComparingTwoTheSameIntegers_ShouldReturnTheyAreEqual()
        {
            //arrange
            var number1 = 10;
            var number2 = 10;
            //act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        //Test floatów (typ wartościowy)
        public void WhenComparingTwoTheSameFloats_ShouldReturnTheyAreEqual()
        {
            //arrange
            var number1 = 10.5;
            var number2 = 10.5;
            //act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]

        //Test właściwości klas, które są stringami (hybryda typów) i intami (typ wartościowy)
        public void WhenComparingTheSamePropertiesOfDifferentClassInstances_ShouldReturnTheyAreEqual()
        {
            //arrange
            var employee1 = new Employee("Paweł", "Puszka");
            var employee2 = new Employee("Paweł", "Puszka");
            //act

            //assert
            Assert.AreEqual(employee1.Name, employee2.Name);
            Assert.AreEqual(employee1.Surname, employee2.Surname);
        }
    }
}

