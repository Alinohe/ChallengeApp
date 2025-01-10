
namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            //arrange
            var employee = new Employee("Julia", "Nowak");
            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(2);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(5, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            //arrange
            var employee = new Employee("Julia", "Nowak");
            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(2);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            //arrange
            var employee = new Employee("Julia", "Nowak");
            employee.AddGrade(5);
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(2);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(3.2, 2), Math.Round(statistics.Average, 2));
        }

    }
}