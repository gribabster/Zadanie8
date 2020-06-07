using System;
using static System.Console;
using static System.Convert;
using studentlib;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Vvod Data: ");
            WriteLine("Day: ");
            int day = ToInt32(ReadLine());
            WriteLine("Month: ");
            int month = ToInt32(ReadLine());
            WriteLine("Year: ");
            int year = ToInt32(ReadLine());
            Class1 a = new Class1();
            int n = 1;
            while (n > 0)
            {
                WriteLine("1 - Dobavit studenta.\n2 - Izmenit dannye studenta.\n3 - Udalit studenta.\n4 - Vse studenty.");
                int m = ToInt32(ReadLine());
                if (m == 1)
                {
                    a.show();
                }
                else if (m == 2)
                {
                    a.initials("ID");
                }
                else if (m == 3)
                {
                    a.Vozrast(m, day, month, year);
                }
                else if (m == 4)
                {

                    a.Vozrast(m, day, month, year);
                }
                WriteLine("Vvod deist:");

                if (n == 2)
                {
                    WriteLine("Vvod ID i izmen. dannye: ");

                    WriteLine("ID: "); string ID = ReadLine();

                    WriteLine("FIO: "); string FIO = ReadLine();

                    WriteLine("Group: "); string GROUP = ReadLine();

                    WriteLine("Data: "); string DATA = ReadLine();

                    a.add(ID, FIO, GROUP, DATA);

                    WriteLine("Vvod deist: ");
                }
                else if (n == 4)
                {
                    WriteLine("Vvod ID i izmen. dannye: ");

                    WriteLine("ID: "); string ID = ReadLine();

                    WriteLine("FIO: "); string FIO = ReadLine();

                    WriteLine("Group: "); string GROUP = ReadLine();

                    WriteLine("Data: "); string DATA = ReadLine();

                    a.change(ID, FIO, GROUP, DATA);

                    WriteLine("Vvod deistе: ");
                }
                else if (n == 3)
                {
                    WriteLine("Vvod ID: ");

                    string ID = ReadLine();

                    a.remov(ID);

                    WriteLine("Vvod deist: ");

                }
                else if (n == 5)
                {
                    {
                        WriteLine("1 - Poisk po ID.\n2 - Poisk po Familii\n");
                        int k = ToInt32(ReadLine());
                        if (m == 1)
                        {
                            WriteLine("Vvod ID: ");
                            string ID = ReadLine();
                            a.initials(ID);
                        }
                        else if (m == 2)
                        {
                            WriteLine("Vvod Familia: ");
                            string famil = ReadLine();
                            a.surname(famil);
                            WriteLine("Vvod deist: ");

                        }
                        else if (n == 6)
                        {
                            Environment.Exit(0);
                        }
                    }




                }
            }
        }
    }   
}