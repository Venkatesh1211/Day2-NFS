using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class student
    {
        public string Name;
        public int Id;

        // Constructor
        public student(string name, int id)
        {
            Name = name;
            Id = id;
        }

        // Display method
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name + ", ID: " + Id);
        }

        // Update name
        public void UpdateName(string newName)
        {
            Name = newName;
        }

        // Update ID
        public void UpdateNewId(int newId)
        {
            Id = newId;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating objects
            student s1 = new student("Ram", 123);
            student s2 = new student("Sai", 345);

            // Display initial data
            s1.DisplayInfo();
            s2.DisplayInfo();

            // Updating values
            s1.UpdateName("Ravi");
            s1.UpdateNewId(189);

            // Display after update
            Console.WriteLine("After Update:");
            s1.DisplayInfo();

            // Keep console open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
