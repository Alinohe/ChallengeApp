namespace ChallengeApp
{
    public class User
    {
        public List<int> score = new List<int>();

        public User(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
            //this.age = age;

        }
        public User(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
       // public int age { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
