using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace prak14
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1
            //Stack<int> st = new Stack<int>();            
            //Console.WriteLine("Введите размерность стека");
            //int answer = Convert.ToInt32(Console.ReadLine());
            //for(int i=1;i<answer+1;i++)
            //{
            //    st.Push(i);
            //}
            //Console.WriteLine($"n= {st.Count}");
            //Console.WriteLine($"Размерность стека {st.Count}");
            //Console.WriteLine($"Верхний элемент стека {st.Peek()}");
            //Console.Write("Содержание стека = ");
            //foreach (var s in st)
            //{
            //    Console.Write(" ");
            //    Console.Write(s);                
            //}
            //st.Clear();
            //Console.WriteLine();
            //Console.WriteLine($"Новая размерность стека {st.Count}");

            //2            
            //Console.WriteLine("Введите математическое выражение со скобками");
            //Console.WriteLine();
            //Stack<char> open = new Stack<char>();
            //Stack<char> closed = new Stack<char>();
            //string sr = Console.ReadLine();
            //StreamWriter sw1 = new StreamWriter("1.txt");
            //sw1.Write(sr);
            //StreamWriter sw2 = new StreamWriter("2.txt");
            //if (string.IsNullOrEmpty(sr) != true)
            //{
            //    for (int i = 0; i < sr.Length; i++)
            //    {
            //        if (sr[i] == '(')
            //        {
            //            open.Push(sr[i]);
            //        }
            //        else if (sr[i] == ')')
            //        {
            //            closed.Push(sr[i]);
            //        }
            //    }
            //    if (open.Count == closed.Count)
            //    {
            //        Console.WriteLine("Всё в порядке");
            //    }
            //    else if (open.Count > closed.Count)
            //    {
            //        sw2.Write(sr);
            //        Console.WriteLine($"Не хватает {open.Count - closed.Count} закрывающих скобок");
            //        int indexOpen = sr.IndexOf('(');
            //        Console.WriteLine($"Возможо лишняя ( скобка в позиции: {indexOpen}");
            //        for (int i = 0; i < open.Count - closed.Count; i++)
            //        {
            //            sw2.Write(')');
            //        }
            //    }
            //    else if (closed.Count > open.Count)
            //    {
            //        Console.WriteLine($"{closed.Count - open.Count} лишних закрывающих скобок");
            //        int indexClosed = sr.IndexOf(')');
            //        Console.WriteLine($"Возможо лишняя ) скобка в позиции: {indexClosed}");
            //        for (int i = 0; i < closed.Count - open.Count; i++)
            //        {
            //            sr = sr.Remove(indexClosed, 1);
            //            sw2.Write(sr);
            //        }
            //    }
            //    sw1.Close();
            //    sw2.Close();
            //}
            //else
            //{
            //    Console.WriteLine("Нужно вводить значения!");
            //}

            //3
            //Console.WriteLine("Введите размерность очереди");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"n= {n}");
            //Queue<int> q = new Queue<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    q.Enqueue(i + 1);
            //}
            //Console.WriteLine($"Размер очереди =  {q.Count}");
            //Console.WriteLine($"Первый элемент очереди {q.Peek()}");
            //Console.Write("Содержимое очереди = ");
            //foreach (int number in q)
            //{
            //    Console.Write(number + " ");
            //}
            //q.Clear();
            //Console.WriteLine($"\nНовый размер очереди =  {q.Count}");

            //4
            //StreamWriter sw3 = new StreamWriter("3.txt");
            //string s1 = "Иванов Сергей Николаевич 21 64";
            //string s2 = "Петров Игорь Юрьевич 45 88";
            //string s3 = "Семёнов Михаил Алексеевич 20 70";
            //string s4 = "Пиманов Александр Дмитриевич 53 101";
            //sw3.WriteLine(s1);
            //sw3.WriteLine(s2);
            //sw3.WriteLine(s3);
            //sw3.WriteLine(s4);
            //sw3.Close();
            //StreamReader sr = new StreamReader("3.txt");
            //string line;
            //Queue<Informations> q = new Queue<Informations>();
            //while (!sr.EndOfStream)
            //{                
            //    string[] InfoSplit = new string[5];
            //    line = sr.ReadLine();
            //    InfoSplit = line.Split(" ");
            //    Informations Inf = new Informations();
            //    Inf.Name = InfoSplit[0];
            //    Inf.Surname = InfoSplit[1];
            //    Inf.Patronymic = InfoSplit[2];
            //    Inf.Age = InfoSplit[3];                
            //    Inf.Weight = InfoSplit[4];
            //    q.Enqueue(Inf);
            //}
            //sr.Close();
            //Console.WriteLine("Все кто старше 40 лет: ");
            //foreach (Informations Inf in q)
            //{

            //    if (Convert.ToInt32(Inf.Age) > 40)
            //    {
            //        Console.WriteLine($"{Inf.Name} {Inf.Surname} {Inf.Patronymic} {Inf.Age} {Inf.Weight}");
            //    }

            //}
            //Console.WriteLine("Остальные: ");
            //foreach (Informations Inf in q)
            //{
            //    if (Convert.ToInt32(Inf.Age) <= 40)
            //    {
            //        Console.WriteLine($"{Inf.Name} {Inf.Surname} {Inf.Patronymic} {Inf.Age} {Inf.Weight}");
            //    }
            //}

            //5
            StreamWriter sw3 = new StreamWriter("6.txt");
            string s1 = "Иванов Сергей Николаевич 21 64";
            string s2 = "Петров Игорь Юрьевич 45 88";
            string s3 = "Семёнов Михаил Алексеевич 20 70";
            string s4 = "Пиманов Александр Дмитриевич 53 101";
            sw3.WriteLine(s1);
            sw3.WriteLine(s2);
            sw3.WriteLine(s3);
            sw3.WriteLine(s4);
            sw3.Close();
            StreamReader sr = new StreamReader("6.txt");
            string line;
            Queue<Informations> q = new Queue<Informations>();
            while (!sr.EndOfStream)
            {
                string[] InfoSplit = new string[5];
                line = sr.ReadLine();
                InfoSplit = line.Split(" ");
                Informations Inf = new Informations();
                Inf.Name = InfoSplit[0];
                Inf.Surname = InfoSplit[1];
                Inf.Patronymic = InfoSplit[2];
                Inf.Age = InfoSplit[3];
                Inf.Weight = InfoSplit[4];
                q.Enqueue(Inf);
            }
            sr.Close();
            Console.WriteLine("Сортировка по возрасту: ");
            IEnumerable<Informations> schet = q.OrderBy(x => x.Age);            
            foreach (Informations Inf in schet)
            {
                Console.Write($"{Inf.Name} {Inf.Surname} {Inf.Patronymic}");                
                Console.Write($" {Inf.Age} ");                
                Console.Write($" {Inf.Weight} ");
                Console.WriteLine();
            }            
        }
    }
}

