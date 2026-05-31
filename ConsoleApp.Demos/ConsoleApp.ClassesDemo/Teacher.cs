using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp.ClassesDemo
{
    public class Teacher : Person
    {
        public void GenerateIdNumber()
        {
            _idNumber = "TCH-" + GetRandomNumber();
        }
    }
}
