﻿namespace ChallengeApp
{
    public abstract class Person 
    {
        public Person()
        {
            this.Name = "no Name";
            this.Surname = "no Surname";
        }
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
       
    }
}
