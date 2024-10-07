using System;
using System.IO;

namespace Person1
{
    class Person
    {
        const int l_name = 30; 
        string name;
        int birth_year;
        double pay;

        public Person()
        {
            name = "Anonimous";
            birth_year = 0;
            pay = 0;
        }

        public Person(string s)
        {
            if (s.Length < 34) 
            {
                throw new FormatException("Invalid string format.");
            }

            name = s.Substring(0, l_name).Trim(); 
            birth_year = Convert.ToInt32(s.Substring(l_name, 4)); 
            pay = Convert.ToDouble(s.Substring(l_name + 4)); 

            if (birth_year < 0) throw new FormatException("Incorrect year of birth.");
            if (pay < 0) throw new FormatException("Incorrect salary.");
        }

        public override string ToString()
        {
            return string.Format("Name: {0,30} Birth: {1} Pay: {2:F2}", name, birth_year, pay);
        }

        public int Compare(string name)
        {
            return string.Compare(this.name, name, StringComparison.OrdinalIgnoreCase);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Birth_year
        {
            get { return birth_year; }
            set
            {
                if (value > 0) birth_year = value;
                else throw new FormatException();
            }
        }

        public double Pay
        {
            get { return pay; }
            set
            {
                if (value > 0) pay = value;
                else throw new FormatException();
            }
        }

        public static double operator +(Person pers, double a)
        {
            pers.pay += a;
            return pers.pay;
        }

        public static double operator +(double a, Person pers)
        {
            pers.pay += a;
            return pers.pay;
        }

        public static double operator -(Person pers, double a)
        {
            pers.pay -= a;
            if (pers.pay < 0) throw new FormatException();
            return pers.pay;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] dbase = new Person[100];
            int n = 0;

            try
            {
                using (StreamReader f = new StreamReader("dbase.txt"))
                {
                    string s;
                    int i = 0;

                    while ((s = f.ReadLine()) != null)
                    {
                        dbase[i] = new Person(s);
                        Console.WriteLine(dbase[i]);
                        ++i;
                    }
                    n = i - 1;
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Check the correctness of the name and path to the file!");
                return;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Very large file!");
                return;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return;
            }

            int n_pers = 0;
            double mean_pay = 0;
            Console.WriteLine("Enter the employee's last name");

            string name;
            while ((name = Console.ReadLine()) != "")
            {
                bool not_found = true;
                for (int k = 0; k <= n; ++k)
                {
                    Person pers = dbase[k];
                    if (pers.Compare(name) == 0)
                    {
                        Console.WriteLine(pers);
                        ++n_pers;
                        mean_pay += pers.Pay;
                        not_found = false;
                    }
                }
                if (not_found) Console.WriteLine("There is no such employee");
                Console.WriteLine("Enter the employee's last name or Enter to finish");
            }

            if (n_pers > 0)
                Console.WriteLine("Average salary: {0:F2}", mean_pay / n_pers);

            Console.ReadKey();
        }
    }
}
