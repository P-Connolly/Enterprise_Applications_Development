using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSpace
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

    public class RepClass
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
                else
                {
                    Student kid = new Student(id, name, gender);
                    Students.Add(kid);
                }
            }
            if (Students.Count == 0)
            {

                Student kid = new Student(id, name, gender);
                Students.Add(kid);
            }

        }


    }
}
