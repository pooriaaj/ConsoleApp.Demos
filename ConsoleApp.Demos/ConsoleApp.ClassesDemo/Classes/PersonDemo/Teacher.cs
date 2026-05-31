using ConsoleApp.ClassesDemo.Utils;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo
{
    public class Teacher : Person
    {
        public void GenerateIdNumber()
        {
            _idNumber = PersonHelper.GenerateIdNumber("TCH-");
        }
    }
}
