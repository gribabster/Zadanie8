﻿using System;
using static System.Console;
using static System.Convert;
using System.Collections.Generic;

namespace studentlib

{
    public class Class1
    {





        class lol
        {




            public class Student

            {
                public string ID;

                public string FIO;

                public string GROUP;

                public string DATA;

            }

            public List<Student> list = new List<Student>();

            public void add(string ID, string FIO, string GROUP, string DATA)

            {
                list.Add(new Student() { ID = ID, FIO = FIO, GROUP = GROUP, DATA = DATA });
            }

            public void remov(string ID)

            {
                for (int i = 0; i < list.Count; i++)

                {
                    if (list[i].ID == ID) list.RemoveAt(i);
                }
            }

            public void change(string ID, string FIO, string GROUP, string DATA)

            {
                for (int i = 0; i < list.Count; i++)

                {
                    if (list[i].ID == ID)

                    {
                        list[i].FIO = FIO;

                        list[i].GROUP = GROUP;

                        list[i].DATA = DATA;

                    }

                }

            }
            public void viv(string ID)

            {
                for (int i = 0; i < list.Count; i++)

                {
                    if (list[i].ID == ID)

                    {
                        Console.WriteLine(list[i].ID + " " + list[i].FIO + " " + list[i].GROUP + " " + list[i].DATA);
                    }
                }
            }
            public void year(string ID, int day1, int month1, int yea1)

            {
                int W;
                int P;
                int vozrast;
                string day = "";
                string month = "";
                string year = "";
                string data = "";

                for (int i = 0; i < list.Count; i++)

                {
                    if (list[i].ID == ID)
                    {
                        data = list[i].DATA + "";
                    }
                }

                W = data.IndexOf(".");
                P = data.LastIndexOf(".");

                for (int i = 0; i < W; i++)
                {
                    day = day + data[i];
                }

                for (int i = W + 1; i < P; i++)
                {
                    month = month + data[i];
                }

                for (int i = P + 1; i < data.Length; i++)
                {
                    year = year + data[i];
                }
                Console.WriteLine("Happy birthday" + day + "." + month + "." + year);
                vozrast = yea1 - ToInt32(year);
                if (ToInt32(month) > month1) vozrast = vozrast - 1;

                else if (ToInt32(month) == month1)
                    if (ToInt32(day) < day1) vozrast = vozrast - 1;
                Console.WriteLine("\nVozrast = " + vozrast);
            }


            public void show()

            {
                foreach (var i in list)

                {
                    Console.WriteLine(i.ID + " " + i.FIO + " " + i.GROUP + " " + i.DATA);
                }


            }
            public void initials(string ID)

            {
                string rezltat = "";
                string pro = "";
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ID == ID)
                    {
                        pro = list[i].FIO;
                    }
                }
                string[] words = pro.Split(' ');
                rezltat = rezltat + words[0] + " " + words[1][0] + "." + words[2][0] + ".";
                Console.WriteLine(rezltat);
            }
            public void surname(string Famil)
            {
                string pro = "";
                for (int i = 0; i < list.Count; i++)
                {
                    pro = list[i].FIO;
                    string[] words = pro.Split(' ');
                    if (Famil == words[0])
                    {
                        Console.WriteLine(list[i].ID + " " + list[i].FIO + " " + list[i].GROUP + " " + list[i].DATA);
                    }
                }
            }

            public void Vozrast(string param, int day1, int month1, int year1)
            {
                for (int m = 0; m < list.Count; m++)
                {
                    int Z;
                    int V;
                    int vozrast;
                    string day = "";
                    string month = "";
                    string year = "";
                    string data;
                    string ID;

                    ID = list[m].ID;
                    data = list[m].DATA + "";
                    Z = data.IndexOf(".");
                    V = data.LastIndexOf(".");

                    for (int i = 0; i < Z; i++)
                    {
                        day = day + data[i];
                    }

                    for (int i = Z + 1; i < V; i++)
                    {
                        month = month + data[i];
                    }

                    for (int i = V + 1; i < data.Length; i++)

                    {
                        year = year + data[i];
                    }

                    vozrast = year1 - ToInt32(year);
                    if (ToInt32(month) > month1) vozrast = vozrast - 1;
                    else if (ToInt32(month) == month1)
                        if (ToInt32(day) < day1) vozrast = vozrast - 1;
                    if (param == "s") if (vozrast < 18) Console.WriteLine(list[m].FIO + " ");
                    if (param == "a") if (vozrast > 18) Console.WriteLine(list[m].FIO + " ");
                }
            }





        }

        public void initials(string v)
        {
            throw new NotImplementedException();
        }

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


                lol a = new lol();

                WriteLine("1 - Dobavit studenta.\n2 - Izmenit dannye studenta.\n3 - Udalit studenta.\n4 - Vse studenty.");

                int n = ToInt32(ReadLine());

                while (n > 0)

                {

                    if (n == 1)

                    {
                        WriteLine("ID: "); string ID = ReadLine();

                        WriteLine("FIO: "); string FIO = ReadLine();

                        WriteLine("Group: "); string GROUP = ReadLine();

                        WriteLine("Data: "); string DATA = ReadLine();

                        a.add(ID, FIO, GROUP, DATA);

                        WriteLine("Vvod deist: ");

                        n = ToInt32(ReadLine());

                    }

                    else if (n == 2)

                    {
                        WriteLine("Vvod ID i izmen. dannye: ");

                        WriteLine("ID: "); string ID = ReadLine();

                        WriteLine("FIO: "); string FIO = ReadLine();

                        WriteLine("Group: "); string GROUP = ReadLine();

                        WriteLine("Data: "); string DATA = ReadLine();

                        a.change(ID, FIO, GROUP, DATA);

                        WriteLine("Vvod deist: ");

                        n = ToInt32(ReadLine());

                    }

                    else if (n == 3)

                    {
                        WriteLine("Vvod ID: ");

                        string ID = ReadLine();

                        a.remov(ID);

                        WriteLine("Vvod deist: ");

                        n = ToInt32(ReadLine());

                    }

                    else if (n == 4)

                    {
                        a.show();

                        WriteLine("Vvod deist: ");

                        n = ToInt32(ReadLine());

                    }
                    else if (n == 5)

                    {
                        WriteLine("Vvod ID: ");
                        string ID = ReadLine();
                        a.viv(ID);
                        WriteLine("Vvod deist: ");
                        n = ToInt32(ReadLine());
                    }

                    else if (n == 6)

                    {
                        WriteLine("Vvod ID: ");
                        string ID = ReadLine();
                        WriteLine("Vvod Data: ");
                        WriteLine("Day: ");
                        int day1 = ToInt32(ReadLine());
                        WriteLine("Month: ");
                        int mont = ToInt32(ReadLine());
                        WriteLine("Year: ");
                        int yea = ToInt32(ReadLine());
                        a.year(ID, day, month, year);
                        WriteLine("Vvod deist: ");
                        n = ToInt32(ReadLine());
                    }
                    else if (n == 7)
                    {
                        WriteLine("Vvod ID: ");
                        string ID = ReadLine();
                        a.initials(ID);
                        WriteLine("Vvod deist: ");
                        n = ToInt32(ReadLine());
                    }
                    else if (n == 8)
                    {
                        WriteLine("Vvod «s» - menshe 18, «a» - starshe 18: ");
                        string param = ReadLine();
                        a.Vozrast(param, day, month, year);
                        WriteLine("Vvod deist: ");
                        n = ToInt32(ReadLine());
                    }
                    else if (n == 9)
                    {
                        WriteLine("Vvod Familia: ");
                        string famil = ReadLine();
                        a.surname(famil);
                        WriteLine("Vvod deist: ");
                        n = ToInt32(ReadLine());
                    }
                }
            }
        }
    }
}
    


