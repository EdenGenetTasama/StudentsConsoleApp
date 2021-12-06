using System;

namespace StudentsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuStart();
            //AppUp();
            //GetListOfStrings("Daniel");
        }

        static void AppUp()
        {


            Console.WriteLine("Please enter Teacher Name:");
            string namOfTeacher = Console.ReadLine();


            Console.WriteLine("How many students would you like to save?");
            int numberOfStudents = int.Parse(Console.ReadLine());


            Console.WriteLine($"Hello {namOfTeacher} , Welcome ☺");

            List<Grades> gradesList = new List<Grades>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Student Name:");
                string studentName = Console.ReadLine();

                Console.WriteLine("Enter student Id:");
                int idOfStu = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter first Grade:");
                int firstGra = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Secound Grade:");
                int SecondGar = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Third Grade:");
                int ThirdGra = int.Parse(Console.ReadLine());

                int[] gradesArray = new int[3] { firstGra, SecondGar, ThirdGra };
                Grades studentObj = new Grades(namOfTeacher, studentName, idOfStu, gradesArray);

                gradesList.Add(studentObj);
            }

            for (int i = 0; i < numberOfStudents; i++)
            {
                FileStream fileStream = new FileStream(@$"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\02.12.2021\Teacher Files\{namOfTeacher}.txt", FileMode.Append);
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine($" ID:{gradesList[i].idNumber} Student name:{gradesList[i].studentName}  Grades:•{gradesList[i].gradesArray[0]}  {gradesList[i].gradesArray[1]}  {gradesList[i].gradesArray[2]},");
                }

            }


        }



        static void MenuStart()
        {
            Console.WriteLine("Welcome To The System , please Select Option:");
            Console.WriteLine("1.Add New Student");
            Console.WriteLine("2.Print Info per Teacher:");
            int userSelect = int.Parse(Console.ReadLine());

            switch (userSelect)
            {
                case 1:
                    try
                    {
                        AppUp();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("value must be number");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;

                case 2:
                    Console.WriteLine("Enter Teacher Name:");
                    string userInput = Console.ReadLine();
                    try
                    {
                        StudentsAvrage(userInput);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("value must be number");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                default:
                    try
                    {
                        MenuStart();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("value must be number");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                    MenuStart();

            }
        }



        static void GetListOfStrings(string teachersFile)
        {
            List<string> stringList = new List<string>();
            FileStream fileStream = new FileStream($@"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\02.12.2021\Teacher Files\{teachersFile}.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                string info = reader.ReadLine();
                stringList.Add(info);
                Console.WriteLine(stringList[0]);
            }

        }

        static void StudentsAvrage(string teacherName)
        {
            FileStream fileStream = new FileStream($@"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\02.12.2021\Teacher Files\{teacherName}.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                string info = reader.ReadLine();
                int holdIndex = info.IndexOf("Grades: ")+7;
                int holdEndIndex = info.IndexOf(",");

                //Console.WriteLine(info.IndexOf("Grades:"));
                //Console.WriteLine(holdIndex);
                //Console.WriteLine(holdEndIndex);
                //info.Substring(holdIndex);

                string allGrades = info.Substring(holdIndex);
                Console.WriteLine(allGrades);

                int firtsGra = allGrades.IndexOf(" ");
                //int firtsGraOut= allGrades.Substring(0, firtsGra);
                //int firstGrade = int.Parse(allGrades.Substring(holdIndex, firtsGra));
                Console.WriteLine(allGrades.Substring(0,4));  // 100
                Console.WriteLine(allGrades.Substring(4, 7));
                //Console.WriteLine(allGrades.Substring(0, 4));

                //int secoundGrade = 6;
                //Console.WriteLine(allGrades.Substring(secoundGrade, 5));//200
                //int secoundGreade = int.Parse(allGrades.Substring(secoundGrade, 5));
                //Console.WriteLine(allGrades.Substring(secoundGrade, 5));




                //Console.WriteLine(allGrades.Substring(12)); //300,




                //int secoundGra = allGrades.IndexOf();



                //Console.WriteLine(int.Parse("100"));
                //Console.WriteLine(Convert.ToInt32(allGrades));

                //Console.WriteLine(info);

            }
        }






    }
}