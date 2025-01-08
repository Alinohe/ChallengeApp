using ChallengeApp;

User user1 = new User("Adam", "32423fddf");
User user2 = new User("Monika", "32423fddf");
User user3 = new User("Zuzia", "32423fddf");


user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(1);
user1.AddScore(7);
user1.AddScore(8);



user2.AddScore(2);
user2.AddScore(5);
user2.AddScore(9);
user1.AddScore(4);
user1.AddScore(7);

user3.AddScore(11);
user3.AddScore(5);
user3.AddScore(6);
user1.AddScore(9);
user1.AddScore(3);

List<User> users = new List<User>()
{
    user1, user2, user3
};

int maxResult = -1;
User userWithMaxResult = null;

foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        maxResult = user.Result;
        userWithMaxResult = user;
    }
}
Console.WriteLine(" Employee with max score is " + " " + " " + userWithMaxResult.Name + " " + "" + userWithMaxResult.Surname + " "  + " " + " lat " + " z wynikikiem " + " " + " " + " " + maxResult);

