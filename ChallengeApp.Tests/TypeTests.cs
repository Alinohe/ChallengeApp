namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CheckIfNumbersAreTheSame()
        {
            //arrange
            int number1 = 10;
            int number2 = 10;

            //act


            //assert
            Assert.AreEqual(number1, number2);


        }

        [Test]

        public void TEST()
        {
            string user1 = ("Adam");
            string user2 = ("Robert");


            Assert.AreNotEqual(user1, user2);
        }

        [Test]


        public void WhenAddedShouldReturnSum()
        {
            string name = "Robert";
            string surname = "Domanski";

            string result = name + surname;

            Assert.AreEqual("RobertDomanski", result);

        }
         public void FloatShouldBeTheSame()
        {
            float number1 = 42.4f;
            float number2 = 42.4f;

            Assert.AreEqual(number1, number2);

        }

        public void FloatShouldNotBeTheSame()
        {
            float number1 = 42.4f;
            float number2 = 21.2f;
            
            Assert.AreNotEqual(number1, number2);
        }




        public User GetUser(string name)
        {
            return new User(name);
        }

    }

}
