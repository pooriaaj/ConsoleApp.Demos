using System.Security.Cryptography;
using ConsoleApp.ClassesDemo.Utils;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    public class Student : Person
    {
        public void GenerateIdNumber()
        {
            _idNumber = PersonHelper.GenerateIdNumber("STU");
        }
    }
}
