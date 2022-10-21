using System.Data;
using System.Reflection.PortableExecutable;

namespace program4
{
    internal class Program
    {                  //1)проблема с временем в кадой заметке 2)исправить работу выхоода 3)

        static void Main(string[] args)
        {
            Data();
            
            
           
            
        }
        static void Data()
        {
            int peremennay = 0;
            DateTime d = DateTime.Now;
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                
                ConsoleKeyInfo key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.LeftArrow)
                {
                    peremennay--;
                    Console.Clear();
                    DateTime t = d.AddDays(peremennay);
                    Console.WriteLine(t);
                    

                }
                if (key2.Key == ConsoleKey.RightArrow)
                {
                    peremennay++;
                    Console.Clear();
                    DateTime t = d.AddDays(peremennay);
                    Console.WriteLine(t);

                }

                if (peremennay == 3)
                {
                    while (key2.Key == ConsoleKey.Escape)
                    Console.WriteLine(" ");
                    Console.WriteLine("   1.Убраться дома");
                    Console.WriteLine("   2.Выучить уроки");
                    if (key2.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        menu(key2);
                    }

                }
                if (peremennay == 6)
                {
                    while (key2.Key == ConsoleKey.Escape)
                    Console.WriteLine(" ");
                    Console.WriteLine("   1.Сходить в зал");
                    Console.WriteLine("   2.Приготовить ужин");
                    if (key2.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        menu1(key2);
                    }

                }
                if (peremennay == 8)
                {
                    while (key2.Key == ConsoleKey.Escape)
                        Console.WriteLine(" ");
                    Console.WriteLine("   1.Покормить кота");
                    if (key2.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        menu2(key2);
                    }

                }
                if (peremennay == 9)
                {
                    while (key2.Key == ConsoleKey.Escape)
                        Console.WriteLine(" ");
                    Console.WriteLine("   1.Помочь другу с уроками");
                    Console.WriteLine("   2.Зайти в магазин");
                    if (key2.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        menu3(key2);
                    }

                }
                if (peremennay == 13)
                {
                    while (key2.Key == ConsoleKey.Escape)
                        Console.WriteLine(" ");
                    Console.WriteLine("   1.Посмотреть аниме");
                    if (key2.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        menu4(key2);
                        
                    }

                }

            }

            
        }
        static void menu(ConsoleKeyInfo key3)
        {

           
            int position = 1;
            ConsoleKeyInfo key4 = Console.ReadKey();
          
            while (key4.Key != ConsoleKey.Enter)
            {


                if (key4.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }
                if (key4.Key == ConsoleKey.DownArrow)
                {
                    position++;


                }
                if (position < 1)
                {
                    position = 1;
                    Console.SetCursorPosition(0, position);
                }
                if (position > 1)
                {
                    position = 2;
                    Console.SetCursorPosition(0, position);
                }
                Console.Clear();
                DateTime h = DateTime.Now;
                Console.WriteLine(h);
                Console.WriteLine("  1.Убраться дома");
                Console.WriteLine("  2.Выучить уроки");
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key4 = Console.ReadKey();
                if (position == 1)
                {
                    
                    ConsoleKeyInfo key5 = key4;

                    if (key5.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("Убраться дома");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("описание:\n1)пропылесосить\n2)протереть пыль\n3)погладить и сложить вещи");
                        DateTime d = DateTime.Now;
                        Console.WriteLine(d);
                    }
                }

                if (position == 2)
                {
                    ConsoleKeyInfo key5 = key4;
                    
                    if (key5.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("Выучить уроки");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("описание:\n1)решить задачи по математике\n2)выучить параграф по истории" +
                            "\n3)повторить параграф по биологии");
                        DateTime i = DateTime.Now;
                        Console.WriteLine(i);
                    }
                }
            }
            
     
        }
        static void menu1(ConsoleKeyInfo key3)
        {


            int position = 1;
            ConsoleKeyInfo key4 = Console.ReadKey();

            while (key4.Key != ConsoleKey.Enter)
            {


                if (key4.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }
                if (key4.Key == ConsoleKey.DownArrow)
                {
                    position++;


                }
                if (position < 1)
                {
                    position = 1;
                    Console.SetCursorPosition(0, position);
                }
                if (position > 1)
                {
                    position = 2;
                    Console.SetCursorPosition(0, position);
                }
                Console.Clear();
                DateTime l = DateTime.Now;
                Console.WriteLine(l);
                Console.WriteLine("   1.Сходить в зал");
                Console.WriteLine("   2.Приготовить ужин");
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key4 = Console.ReadKey();
                if (position == 1)
                {

                    ConsoleKeyInfo key5 = key4;

                    if (key5.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("Сходить в зал");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("описание:\n1)сделать разминку\n2)сделать упражнения на ноги" +
                            "\n3)сделать упражнения на руки\n4)пойти в душ");
                        DateTime y = DateTime.Now;
                        Console.WriteLine(y);
                    }
                }

                if (position == 2)
                {
                    ConsoleKeyInfo key5 = key4;

                    if (key5.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("Приготовить ужин");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("описание:\n1)зайти в магазин за пельменеми\n2)сварить пельмени" +
                            "\n3)подать пельмени со сметаной");
                        DateTime t = DateTime.Now;
                        Console.WriteLine(t);
                    }
                }
            }


        }
        static void menu2(ConsoleKeyInfo key3)
        {


            int position = 1;
            ConsoleKeyInfo key4 = Console.ReadKey();

            while (key4.Key != ConsoleKey.Enter)
            {


                if (key4.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }
                if (key4.Key == ConsoleKey.DownArrow)
                {
                    position++;


                }
                if (position < 1)
                {
                    position = 1;
                    Console.SetCursorPosition(0, position);
                }
                if (position > 1)
                {
                    position = 1;
                    Console.SetCursorPosition(0, position);
                }
                Console.Clear();
                DateTime h = DateTime.Now;
                Console.WriteLine(h);
                Console.WriteLine("   1.Покормить кота");
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key4 = Console.ReadKey();
                if (position == 1)
                {

                    ConsoleKeyInfo key5 = key4;

                    if (key5.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        DateTime d = DateTime.Now;
                        Console.WriteLine(d);
                        Console.WriteLine("Покормить кота");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("описание:\n1)позвать кота\n2)насыпать в миску корм" +
                            "\n3)в другую миску налить воды");
                    }
                }
            }


        }
        static void menu3(ConsoleKeyInfo key3)
        {


            int position = 1;
            ConsoleKeyInfo key4 = Console.ReadKey();

            while (key4.Key != ConsoleKey.Enter)
            {


                if (key4.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }
                if (key4.Key == ConsoleKey.DownArrow)
                {
                    position++;


                }
                if (position < 1)
                {
                    position = 1;
                    Console.SetCursorPosition(0, position);
                }
                if (position > 1)
                {
                    position = 2;
                    Console.SetCursorPosition(0, position);
                }
                Console.Clear();
                DateTime h = DateTime.Now;
                Console.WriteLine(h);
                Console.WriteLine("   1.Помочь другу с уроками ");
                Console.WriteLine("   2.Зайти в магазин");
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key4 = Console.ReadKey();
                if (position == 1)
                {

                    ConsoleKeyInfo key5 = key4;

                    if (key5.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        DateTime m = DateTime.Now;
                        Console.WriteLine(m);
                        Console.WriteLine("Помочь другу с уроками");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("описание:\n1)зайти к другу домой\n2)выяснить что именно не понятно другу" +
                            "\n3)попытаться объяснить не понятную тему");
                    }
                }
                if (position == 2)
                {

                    ConsoleKeyInfo key5 = key4;

                    if (key5.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        DateTime m = DateTime.Now;
                        Console.WriteLine(m);
                        Console.WriteLine("Зайти в магазин");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("описание:\n1)зарание написать список продуктов\n2)купить нужные продукты в магазине");
                    }
                }
            }


        }
        static void menu4(ConsoleKeyInfo key3)
        {


            int position = 1;
            ConsoleKeyInfo key4 = Console.ReadKey();

            while (key4.Key != ConsoleKey.Enter)
            {


                if (key4.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }
                if (key4.Key == ConsoleKey.DownArrow)
                {
                    position++;


                }
                if (position < 1)
                {
                    position = 1;
                    Console.SetCursorPosition(0, position);
                }
                if (position > 1)
                {
                    position = 1;
                    Console.SetCursorPosition(0, position);
                }
                Console.Clear();
                DateTime h = DateTime.Now;
                Console.WriteLine(h);
                Console.WriteLine("   1.Посмотреть аниме");
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key4 = Console.ReadKey();
                if (position == 1)
                {

                    ConsoleKeyInfo key5 = key4;

                    if (key5.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        DateTime d = DateTime.Now;
                        Console.WriteLine(d);
                        Console.WriteLine("Посмотреть аниме");
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("описание:\n1)посмотреть 1 серию\n2)посмотреть 2 серию" +
                            "\n3)посмотреть 3 серию\n4)посмотреть 4 серию\n5)посмотреть 5 серию" +
                            "\n6)посмотреть 6 серию\n7)посмотреть 7 серию\n8)посмотреть 8 серию\n9)поспать");
                    }
                }
            }


        }


    }
}






