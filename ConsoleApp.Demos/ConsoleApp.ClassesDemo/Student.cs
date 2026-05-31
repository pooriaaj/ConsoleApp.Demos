using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo
{
    public class Student : Person
    {
        public void GenerateIdNumber()
        {
            _idNumber = "STU-" + GetRandomNumber();
        }
    }
}
