using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_Teachers
{
    class Academy
    {
        public Teacher[] Teachers { get; set; }
        public int Teachers_count { get; set; }
        public Academy()
        {
            Teachers = default;
            Teachers_count = 0;
        }
        public Academy(Teacher teacher)
        {
            var test = new Teacher[++Teachers_count];
            if (Teachers != null)
            {
                Teachers.CopyTo(test, 0);
            }
            test[Teachers_count - 1] = teacher;
            Teachers = test;
            //Teachers[Teachers_count] = teacher;
            //++Teachers_count;
        }

        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine($" + + + + + + + + + + + + + + + + + + + + + + + + + + + ");
            Console.WriteLine($" Academy {Teachers_count+1} Informations ");
            for (int i = 0; i < Teachers_count; i++)
            {
                Teachers[i].Show_teacher();
            }
        }
    }
    class Teacher
    {
        public Group[] Groups { get; set; }
        public int Groups_count { get; set; }
        public Teacher()
        {
            Groups = default;
            Groups_count = 0;
        }
        public Teacher(Group group)
        {
            Groups[Groups_count] = group;
            ++Groups_count;
        }
        public void Add_Teacher(Group group)
        {
            var test = new Group[++Groups_count];
            if (Groups != null)
            {
                Groups.CopyTo(test, 0);
            }
            test[Groups_count - 1] = group;
            Groups = test;
            //Groups[Groups_count] = group;
            //++Groups_count;
        }
        public void StartExam(Exam lesson_name,Group group_name)
        {
            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].Name == group_name.Name)
                {
                    for (int k = 0; k < Groups[i].Students.Length; k++)
                    {
                        for (int l = 0; l < Groups[i].Students[k].Exams.Length; l++)
                        {
                            
                            int random=RandomFunction();
                            Groups[i].Students[k].Exams[l].Score = random;
                            random = 0;
                        }
                    }
                }
            }
            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].Name == group_name.Name)
                {
                    for (int k = 0; k < Groups[i].Students.Length; k++)
                    {
                        for (int l = 0; l < Groups[i].Students[k].Exams.Length; l++)
                        {
                            Console.WriteLine($" Group Name : {Groups[i]}  \n Student Name : {Groups[i].Students[k].Name}  \n Student Score : {Groups[i].Students[k].Exams[l].Score} \n\n\n"  ); 
                        }
                    }
                }
            }
        }
        public int RandomFunction()
        {
            Random random_num = new Random();
            int random = random_num.Next(1, 6);
            //Groups[i].Students[k].Exams[l].Score = random;
            return random;
        }
        public void Show_teacher()
        {
            Console.WriteLine($" - - - - - - - - - - - - - - ");
            Console.WriteLine($" Teacher {Groups_count} Informations ");
            for (int i = 0; i < Groups_count; i++)
            {
                Groups[i].Show();
            }
        }
    }
    class Group
    {
        public string Name { get; set; }
        public Student[] Students { get; set; }
        int Students_count { get; set; }
        public Group()
        {
            Students = default;
            Students_count = 0;
            Name = string.Empty;
        }
        public Group(Student student,string name)
        {
            Students[Students_count] = student;
            Name = name;
            ++Students_count;
        }
        public void Add_Student(Student student)
        {
            var test = new Student[++Students_count];
            if (Students != null)
            {
                Students.CopyTo(test, 0);
            }
            test[Students_count - 1] = student;
            Students = test;
            //Students[Students_count] = student;
            //++Students_count;
        }
        public void Show()
        {
            Console.WriteLine($" - - - - - - - - - - - - - - ");
            Console.WriteLine($" Group {Students_count} Information ");
            Console.WriteLine($" Group Name : {Name} ");
            for (int i = 0; i < Students_count; i++)
            {
                Students[i].Show();
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Exam[] Exams { get; set; }
        int Exams_count { get; set; }
        public Student()
        {
            Name = string.Empty;
            Email = string.Empty;
            Exams = default;
            Exams_count = 0;
        }

        public Student(string name, string email, Exam exam)
        {
            Name = name;
            Email = email;
            Exams[Exams_count] = exam;
            ++Exams_count;
        }

        public void Add_exam(Exam exam)
        {
            var test = new Exam[++Exams_count];
            if (Exams != null)
            {
                Exams.CopyTo(test, 0);
            }
            test[Exams_count - 1] = exam;
            Exams = test;
            //Exams[Exams_count] = exam;
            //++Exams_count;
        }

        public void Show()
        {
            Console.WriteLine($" - - - - - - - - - - - - - - ");
            Console.WriteLine($" Student {Exams_count} Informations ");
            for (int i = 0; i < Exams_count; i++)
            {
                Exams[i].Show();
            }
        }
    }
    class Exam
    {
        public string Lesson { get; set; }
        public int Score { get; set; }
        public Exam()
        {
            Lesson = string.Empty;
            Score = 0;
        }
        public Exam(string lesson)
        {
            Lesson = lesson;
            Score = 0;
        }
        public void Show()
        {
            Console.WriteLine($" - - - - - - - - - - - - - - ");
            Console.WriteLine($" Exam Informations ");
            Console.WriteLine($" Lesson : {Lesson} ");
            Console.WriteLine($" Score : {Score} ");
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Exam exam1 = new Exam(" lesson 1 ");
            Exam exam2 = new Exam(" lesson 2 ");
            Exam exam3 = new Exam(" lesson 3 ");

            Student student1 = new Student();
            student1.Add_exam(exam1);
            student1.Add_exam(exam2);
            student1.Add_exam(exam3);
            
            Exam exam4 = new Exam(" lesson 4 ");
            Exam exam5 = new Exam(" lesson 5 ");
            Exam exam6 = new Exam(" lesson 6 ");

            Student student2 = new Student();
            student2.Add_exam(exam4);
            student2.Add_exam(exam5);
            student2.Add_exam(exam6);
            
            Exam exam7 = new Exam(" lesson 7 ");
            Exam exam8 = new Exam(" lesson 8 ");
            Exam exam9 = new Exam(" lesson 9 ");

            Student student3 = new Student();
            student3.Add_exam(exam7);
            student3.Add_exam(exam8);
            student3.Add_exam(exam9);

            Group group1 = new Group();
            group1.Add_Student(student1);
            group1.Add_Student(student2);
            group1.Add_Student(student3);

            Exam exam10 = new Exam(" lesson 10 ");
            Exam exam11 = new Exam(" lesson 11 ");
            Exam exam12 = new Exam(" lesson 12 ");

            Student student4 = new Student();
            student4.Add_exam(exam10);
            student4.Add_exam(exam11);
            student4.Add_exam(exam12);
            
            Exam exam13 = new Exam(" lesson 13 ");
            Exam exam14 = new Exam(" lesson 14 ");
            Exam exam15 = new Exam(" lesson 15 ");

            Student student5 = new Student();
            student5.Add_exam(exam13);
            student5.Add_exam(exam14);
            student5.Add_exam(exam15);
            
            Exam exam16 = new Exam(" lesson 16 ");
            Exam exam17 = new Exam(" lesson 17 ");
            Exam exam18 = new Exam(" lesson 18 ");
            
            Student student6 = new Student();
            student6.Add_exam(exam16);
            student6.Add_exam(exam17);
            student6.Add_exam(exam18);

            Group group2 = new Group();
            group2.Add_Student(student4);
            group2.Add_Student(student5);
            group2.Add_Student(student6);
            
            Exam exam19 = new Exam(" lesson 19 ");
            Exam exam20 = new Exam(" lesson 20 ");
            Exam exam21 = new Exam(" lesson 21 ");
            
            Student student7 = new Student();
            student7.Add_exam(exam19);
            student7.Add_exam(exam20);
            student7.Add_exam(exam21);
            
            Exam exam22 = new Exam(" lesson 22 ");
            Exam exam23 = new Exam(" lesson 23 ");
            Exam exam24 = new Exam(" lesson 24 ");

            Student student8 = new Student();
            student8.Add_exam(exam22);
            student8.Add_exam(exam23);
            student8.Add_exam(exam24);
            
            Exam exam25 = new Exam(" lesson 25 ");
            Exam exam26 = new Exam(" lesson 26 ");
            Exam exam27 = new Exam(" lesson 27 ");

            Student student9 = new Student();
            student9.Add_exam(exam25);
            student9.Add_exam(exam26);
            student9.Add_exam(exam27);

            Group group3 = new Group();
            group3.Add_Student(student7);
            group3.Add_Student(student8);
            group3.Add_Student(student9);
            
            Teacher teacher1 = new Teacher();
            teacher1.Add_Teacher(group1);
            teacher1.Add_Teacher(group2);
            teacher1.Add_Teacher(group3);
            
            Academy academy = new Academy(teacher1);
            
            teacher1.StartExam(exam1, group1);
            
        }

    }

}
