using System;

namespace Nullbale_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = {"Rakif Sharifov", "Faqan Sharifov", "Cavid Mikayilov", "Kenan Nebiyev" };
            string opt;
            Console.WriteLine(HasA(students[i]));


            do
            {
                Console.WriteLine("\n1. Butun telebelere bax");
                Console.WriteLine("2. Yeni telebe elave et");
                Console.WriteLine("3. Telebeler uzre axtaris et ");
                Console.WriteLine("4. Telebelerin adlarına bax");
                Console.WriteLine("5. Siyahıda adın olub olmadığına bax");
                Console.WriteLine("0  Menudan çıx");
                Console.WriteLine("\nsecim edin");

                
                opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        for (int i = 0; i < students.Length; i++)                       
                        {
                            Console.WriteLine(students[i]);
                        }
                        break;

                    case "2":
                        Console.WriteLine("telebenin ad ve soy adini qeyd edin");
                        string std = Console.ReadLine();
                        Array.Resize(ref students, students.Length + 1);
                        students[students.Length - 1] = std;
                        break;

                    case "3":
                        
                            Console.WriteLine("");
                        
                        break;

                    case "4":
                        static string FindFirstName(string students)
                        {
                            string word = "";

                            for (int i = 0; i < students.Length; i++)
                            {
                                if (students[i] == ' ')
                                    break;

                                word += students[i];
                            }

                            return word;
                        }                      
                        
                        break;

                    case "5":
                        static bool HasA(string students)

                        {
                            for (int i = 0; i < students.Length; i++)
                            {
                                if (students[i] == students[i])
                                {
                                    return true;
                                }
                            }

                            return false;

                        }



                        
                        
                        break;

                    case "0":
                        
                            Console.WriteLine("");
                        
                        break;

                    default:              
                        
                            Console.WriteLine("seciminiz yanlisdir yeniden reqem daxil edin");     
                        
                        break;
                }
            } while (opt!="0");

        }
    }
}
