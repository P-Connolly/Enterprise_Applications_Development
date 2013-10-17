using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Student
    {

        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public Student(string id, string name, string gender)
        {
            ID = id;
            Name = name;
            Gender = gender;
        }
       

    }

    public class RepClass:IEnumerable
    {
        public RepClass(string crn, string lecturer)
        {
            CRN = crn;
            Lecturer = lecturer;
        }
        public Student this[int studentLocation]
        {
            get
            {
                try
                {
                    return (Student)Students[studentLocation];
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range, returning first student in list.");
                    return (Student)Students[0];
                }
            }
            set { Students[studentLocation] = value; }
        }
        public Student this[string ID]
        {
            get { return getStudentID(ID); }
        }
        string CRN { get; set; }
        string Lecturer { get; set; }
        public List<Student> Students = new List<Student>();

        public IEnumerator GetEnumerator()
        {

            for (int index = 0; index < Students.Count(); index++)
            {
                // Yield each day of the week. 
                yield return Students[index].Name;
            }
        }

        public Student getStudentID(string ID)
        {
            Student x = new Student("", "", "");

            foreach (var item in Students)
            {
                x = (Student)item;
                if (x.ID == ID)
                    return x;
            }
            return x;
        }



        public void AddStudent(string id, string name, string gender)
        {
            Student kid1 = new Student("", "", "");

            foreach (var item in Students.ToArray())
            {
                kid1 = (Student)item;

                if (id == kid1.ID)
                {

                    throw new FormatException("This student is already within the class");
                }
              
            }
            if (Students.Count == 0)
            {

                Student kid = new Student(id, name, gender);
                Students.Add(kid);
            }
            else if (Students.Count >= 1)
            {
                Student kid = new Student(id, name, gender);
                Students.Add(kid);
            }
        }
        public class Test
        {
            public static void Main()
            {
                Student x = new Student("", "", "");
                RepClass testClass = new RepClass("Rang Seamus", "Mr. Connolly");
                
               

                testClass.AddStudent("101", "Dave", "Male");
                testClass.AddStudent("102", "Michael", "Male");
                testClass.AddStudent("103", "Ninja", "Female");

                Console.WriteLine("Student returned using first index:" + testClass[1].ID);
                Console.WriteLine("Student returned using Second index:" + testClass["103"].Gender);

                foreach (var student in testClass)
                {
                    Console.WriteLine(student);
                }

                Console.ReadLine();

            }
        }

    }
}
