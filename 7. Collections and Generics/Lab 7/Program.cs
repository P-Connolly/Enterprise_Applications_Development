using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LogicSpace
{
    
        public class Test
        {
            public static void Main()
        {
            Student x = new Student("","","");
            RepClass testClass = new RepClass("Rang Seamus", "Mr. Connolly");

            testClass.AddStudent("101", "Dave", "Male");
            testClass.AddStudent("102", "Michael", "Male");
            testClass.AddStudent("103", "Ninja", "Female");
                
            Console.WriteLine("Student returned using first index:" + testClass[1].ID);
            Console.WriteLine("Student returned using Second index:" + testClass["103"].Gender);
            Console.ReadLine();

        }
        }
    }

