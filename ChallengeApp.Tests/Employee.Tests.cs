namespace ChallengeApp.Tests
{
    public class Tests
    {


        [Test]
             public void WhenAddAnyEmployeeScores_ThenCorrectMinValue()
        {
            // Arrange
            var employee = new EmployeeInMemory("Jan", "Dêbski");

            employee.AddGrade(3);
            employee.AddGrade(0);
            employee.AddGrade(1);
            employee.AddGrade(100);
            employee.AddGrade(80);

            // Act
            var statistics = employee.GetStatistics();
            //statistics.Min = 99; // Mo¿na "zepsuæ" test, bo wszystkie propercje w klasie
            // Statistics maj¹ publiczny set. Jest tak, bo zmienne Min, Max, Average
            // s¹ ustawiane w klasie Employee.
            // Na razie nie wiem jak to mo¿na naprawiæ - nie zagl¹da³em jeszcze do lekcji
            // dnia 10
            // statistics.Min = 99;

            // Assert
            //Assert.That(statistics.Min, Is.EqualTo(0f)); // Poprawione po Warning NUnit2005 
            Assert.That(statistics.Min, Is.EqualTo(0f));
        }

        [Test]
        public void WhenAddEmployeeScores_ThenCorrectMaxValue()
        {
            // Arrange
            var employee = new EmployeeInMemory("Karol", "Grzyb");

            employee.AddGrade(3);
            employee.AddGrade(0);
            employee.AddGrade(1);
            employee.AddGrade(40);
            employee.AddGrade(100);
            employee.AddGrade(80);

            // Act
            var statistics = employee.GetStatistics();
            // Assert
            //Assert.That(statistics.Max, Is.EqualTo(3f));
            Assert.That(statistics.Max, Is.EqualTo(100f));
        }

        [Test]

        public void WhenAddEmployeeScores_ThenCorrectAvgValue()
        {
            // Arrange
            var employee = new EmployeeInMemory("Hanna", "Solska");

            employee.AddGrade(3);
            employee.AddGrade(30);
            employee.AddGrade(0);
            employee.AddGrade(1);
            employee.AddGrade(100);

            // Act
            var statistics = employee.GetStatistics();

            // Assert
            //Assert.That(statistics.Average, Is.EqualTo(1.33333337f));
            // tutaj mia³em problem jak zapisaæ oczekiwan¹ wartoœæ 1.(3),
            // ale pomóg³ mi nieudany test, który powiedzia³ czego oczekuje,
            // a to zgadza³o siê z moj¹ intuicj¹ matematyczn¹ 1 . 3 na siedmiu miejscach
            var value = Math.Round(statistics.Average, 2);
            Assert.That(value, Is.EqualTo(43.33d));
        }

        [Test]
        public void WhenAddEmployeeScores_ThenCorrectAvgLetter()
        {
            // Arrange
            var employee = new EmployeeInMemory("Anna","MIzian");
            employee.AddGrade(30);
            employee.AddGrade(0);
            employee.AddGrade(100);

            // Act
            var statistics = employee.GetStatistics();
            // Assert
            Assert.That(statistics.AverageLetter, Is.EqualTo('C'));
        }
    }
}
