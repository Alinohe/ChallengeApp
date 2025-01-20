namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        //event EmployeeBase.GradeAddedDelegate GradeAdded;

        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(string grade);
        void AddGrade(char grade);

        //event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();
    }
}