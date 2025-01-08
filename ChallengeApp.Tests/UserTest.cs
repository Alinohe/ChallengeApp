
namespace ChallengeApp.Tests
{
    public class UserTests
    {

        [Test]
        public void CheckSumOperation()
        {
            //arrange
            var user = new User("Adam", "Haslo");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(4);
            user.AddScore(3);
            user.AddScore(7);


            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(25, result);
       
        }

        [Test]
        public void CheckSumOperation1()
        {
            //arrange
            var user = new User("Robert", "Haslo");
            user.AddScore(9);
            user.AddScore(6);
            user.AddScore(7);
            user.AddScore(2);
            user.AddScore(8);


            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(32, result);

        }

        [Test]
        public void CheckSumOperation2()
        {
            //arrange
            var user = new User("Adam", "Haslo");
            user.AddScore(7);
            user.AddScore(4);
            user.AddScore(8);
            user.AddScore(5);
            user.AddScore(7);


            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(31, result);

        }
    }
}
