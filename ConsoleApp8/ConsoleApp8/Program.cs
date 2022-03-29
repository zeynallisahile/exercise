using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student()
            {
                FullName = "Arif Babayev",
                GroupNo = "AP300",
                Age = 25
            };

            Student student2 = new Student()
            {
                FullName = "Aygun Qarayeva",
                GroupNo = "AL203",
                Age = 20
            };
            Console.WriteLine($"FullName: {FullName} - GroupNo: {GroupNo} - Age: {Age} ");
        }
    }
}