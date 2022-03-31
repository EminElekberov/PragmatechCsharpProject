using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            //Student st = new Student("Domation", "Road", 25);
            //Student st2 = new Student("Nofel", "Salahov", 22);
            //st.Counter();
            //st2.Counter();




            #endregion

            Console.WriteLine("------------");
            Console.WriteLine("------------");
            Console.WriteLine("------------------");
            #region task2 
            Rectangle rc = new Rectangle();
            Circle cr = new Circle();
            Triangle tr = new Triangle();
            Square sq = new Square();
            Console.WriteLine("hansi fiqueun sahesini gormek isdeyirsniz \n" +
                "1) Rectangle \n" +
                "2)Circle \n" +
                "3)Triangle \n" +
                "4)Square");
            string choose = Console.ReadLine();

            switch (choose)
            {

                case "1":
                    Console.WriteLine("a ni daxil edin");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("b ni daxil edin");
                    int b = Convert.ToInt32(Console.ReadLine());
                    rc.CalculatePerimeter(a, b);
                    rc.CalculateArea(a, b);
                    break;
                case "2":
                    Console.WriteLine("radiusu daxil edin");
                    int r = Convert.ToInt32(Console.ReadLine());
                    cr.CalculatePerimeter(r);
                    cr.CalculateArea(r);
                    break;
                case "3":
                    Console.WriteLine("a ni daxil edin");
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("b ni daxil edin");
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("b ni daxil edin");
                    int c1 = Convert.ToInt32(Console.ReadLine());
                    tr.CalculateArea(a1, b1, c1);
                    tr.CalculatePerimeter(a1, b1, c1);
                    break;
                case "4":
                    Console.WriteLine("a ni daxil edin");
                    int a2 = Convert.ToInt32(Console.ReadLine());
                    sq.CalculateArea(a2);
                    sq.CalculatePerimeter(a2);
                    break;
                default:
                    Console.WriteLine("dogru emeliyyat girmediniz");
                    break;
            }
        }


    }
    interface Ifugure
    {
        //
        void CalculatePerimeter(int a, int b);
        void CalculateArea(int a, int b);
        void CalculatePerimeter(int a);
        void CalculateArea(int a);
        void CalculatePerimeter(int a, int b, int c);
        void CalculateArea(int a, int b, int c);

    }
    public class Rectangle : Ifugure
    {
        public void CalculateArea(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("rectangle nin sahesi " + result);
        }

        public void CalculateArea(int a)
        {
            throw new NotImplementedException();
        }

        public void CalculateArea(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter(int a, int b)
        {
            int result = 2 * (a + b);
            Console.WriteLine("duzbucaqlinin perimetri " + result);
        }

        public void CalculatePerimeter(int a)
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter(int a, int b, int c)
        {
            throw new NotImplementedException();
        }
    }
    public class Circle : Ifugure
    {
        public void CalculatePerimeter(int a)
        {
            int result = 6 * a;
            Console.WriteLine("dairenin perimetri " + result);
        }
        public void CalculateArea(int a)
        {
            int result = a * a;
            Console.WriteLine("dairenin sahesi " + result);
        }
        public void CalculateArea(int a, int b)
        {
            throw new NotImplementedException();
        }
        public void CalculatePerimeter(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public void CalculateArea(int a, int b, int c)
        {
            throw new NotImplementedException();
        }
    }
    public class Triangle : Ifugure
    {
        public void CalculateArea(int a, int b, int c)
        {
            int result = a * b * c;
            Console.WriteLine("ucbucagin sahesi " + result);
        }
        public void CalculatePerimeter(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine("ucbucagin perimetri " + result);
        }
        public void CalculateArea(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void CalculateArea(int a)
        {
            throw new NotImplementedException();
        }


        public void CalculatePerimeter(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter(int a)
        {
            throw new NotImplementedException();
        }


    }
    public class Square : Ifugure
    {
        public void CalculatePerimeter(int a)
        {
            int result = 4 * a;
            Console.WriteLine("kvadratin perimetri " + result);
        }
        public void CalculateArea(int a)
        {
            int result = a * a;
            Console.WriteLine("kvadratin sahesi " + result);
        }

        public void CalculateArea(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void CalculateArea(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter(int a, int b)
        {
            throw new NotImplementedException();
        }



        public void CalculatePerimeter(int a, int b, int c)
        {
            throw new NotImplementedException();
        }
    }
    #endregion


    #region task3
    //        while (true)
    //        {
    //            Calculator clt = new Calculator();
    //            Console.WriteLine("hansi emeliyyati girmek isdeyirsiniz? \n" +
    //                "1) Sum \n" +
    //                "2) Multiply \n" +
    //                "3) Difference \n" +
    //                "4) Divide ");
    //            string select = Console.ReadLine();
    //            switch (select)
    //            {
    //                case "1":
    //                    clt.Sum();
    //                    break;
    //                case "2":
    //                    clt.Multiply();
    //                    break;
    //                case "3":
    //                    clt.Difference();
    //                    break;
    //                case "4":
    //                    clt.Divide();
    //                    break;
    //                default:
    //                    Console.WriteLine("dogru emeliyyati girin");
    //                    break;
    //            }
    //        }

    //    }
    //}

    //interface ISum
    //{
    //    double param(params double[] list);
    //    void Sum();
    //}
    //interface IMultiply
    //{
    //    double param(params double[] list);
    //    void Multiply();

    //}
    //interface IDifference
    //{
    //    double param(params double[] list);
    //    void Difference();
    //}
    //interface IDivide
    //{
    //    double param(params double[] list);
    //    void Divide();
    //}

    //public class Calculator : ISum, IMultiply, IDifference, IDivide
    //{

    //    public double param(params double[] list)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Sum()
    //    {
    //        Console.WriteLine("diqqet 5 reqem daxil edilecekdir");
    //        Console.WriteLine("--------------------------");
    //        int[] arr = new int[5];
    //        int sum = 0;
    //        Console.WriteLine("edeleri daxil edin");
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            Console.WriteLine(i + 1 + ".ededi daxil edin");
    //            arr[i] = Convert.ToInt32(Console.ReadLine());
    //        }
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            sum += arr[i];

    //        }
    //        Console.WriteLine("edelerin cemi " + sum);
    //    }
    //    public void Multiply()
    //    {
    //        Console.WriteLine("diqqet 5 reqem daxil edilecekdir");
    //        Console.WriteLine("--------------------------");
    //        int[] arr = new int[5];
    //        int Multiple = 1;
    //        Console.WriteLine("edeleri daxil edin");
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            Console.WriteLine(i + 1 + ".ededi daxil edin");
    //            arr[i] = Convert.ToInt32(Console.ReadLine());
    //        }
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            Multiple *= arr[i];

    //        }
    //        Console.WriteLine("edelerin hasili " + Multiple);
    //    }

    //    public void Difference()
    //    {
    //        Console.WriteLine("diqqet 2 reqem daxil edilecekdir");
    //        Console.WriteLine("--------------------------");
    //        int[] arr = new int[2];
    //        int differnce = 0;
    //        Console.WriteLine("edeleri daxil edin");
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            Console.WriteLine(i + 1 + ".ededi daxil edin");
    //            arr[i] = Convert.ToInt32(Console.ReadLine());
    //        }
    //        if (arr[0] > arr[1])
    //        {
    //            for (int i = 0; i < arr.Length; i++)
    //            {
    //                differnce = arr[0] - arr[1];
    //            }
    //            Console.WriteLine("edelerin ferqi  " + differnce);
    //        }
    //        else
    //        {
    //            Console.WriteLine("2 ci eded 1 ciden boyuk ola bilmez");
    //        }

    //    }

    //    public void Divide()
    //    {

    //        Console.WriteLine("diqqet 2 reqem daxil edilecekdir");
    //        Console.WriteLine("--------------------------");
    //        int[] arr = new int[2];
    //        int devide=0;
    //        Console.WriteLine("edeleri daxil edin");
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            Console.WriteLine(i + 1 + ".ededi daxil edin");
    //            arr[i] = Convert.ToInt32(Console.ReadLine());
    //        }
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            devide = arr[0] / arr[1];

    //        }
    //        Console.WriteLine("edelerin qismeti " + devide);
    //    }
    //}
    #endregion
}
    
    interface ICount
    {
        void Counter();
    }
    class Student : ICount
    {
        public string Name { get; set; }
        public string Surename { get; set; }
        public int Age { get; set; }
        public static int sum;
        private int Number;

        public Student(string name, string surename, int age)
        {
            this.Name = name;
            this.Surename = surename;
            this.Age = age;
            sum++;
            this.Number = sum;

        }

        public void Counter()
        {
            Console.WriteLine($" {this.Number} defe instance edildi.");
        }
    }
