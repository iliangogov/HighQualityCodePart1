namespace Homework.Task2
{
   public class StartUp
    {
        public void MakePerson(int age)
        {
            Person newPerson = new Person();
            newPerson.Age = age;

            if (age % 2 == 0)
            {
                newPerson.Name = "BigBrother";
                newPerson.Gender = Gender.Male;
            }
            else
            {
                newPerson.Name = "HotChick";
                newPerson.Gender = Gender.Female;
            }
        }
    }
}
