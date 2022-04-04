using System;

namespace Casting
{
    class Program:Object
    {
        public enum Error { NotFound=404,ServerSideError=500,BadRequest=400};
        static void Main(string[] args)
        {
            #region Nullable value type
            //int? a = null;
            //GetProduct(null);
            //bool? test = null;
            #endregion

            #region Enum
            //foreach (var item in Enum.GetValues(typeof(Error)))
            //{
            //    Console.WriteLine((int)item);
            //}
            //Console.WriteLine(Error.ServerSideError);
            //int error = (int)Error.BadRequest;
            //switch (error)
            //{
            //    case (int)Error.NotFound:
            //        Console.WriteLine(Error.NotFound);
            //        break;
            //    case (int)Error.BadRequest:
            //        Console.WriteLine(Error.BadRequest);
            //        break;
            //    default:
            //        Console.WriteLine("Other error");
            //        break;
            //}
            #endregion

            #region Struct
            //Area area;
            //area.Length = 10;
            //Area area1 = new Area();
            //Area area = new Area(20, 10);
            #endregion

            #region Casting
            #region Upcasting,boxing,implicit
            //Notebook notebook = new Notebook();
            //object product = notebook;
            #endregion
            #region Downcasting,unboxing,explicit
            Notebook notebook = new Notebook();
            Potato potato = new Potato();
            int a = 5;
            bool test = true;
            Product[] products = { notebook, potato };

            foreach (var item in products)
            {
                #region Downcasting - 1 security way - AS
                //Notebook n = item as Notebook;
                //if (n != null)
                //{
                //    n.Print();
                //}
                #endregion
                #region Downcasting - 2 security way - IS
                //if(item is Notebook)
                //{
                //    item.Print();
                //}
                #endregion
            }
            #endregion

            //long n = 10000000000;
            //int b = (int)n;
            //double n2 = 10.02;
            //int x = (int)n2;
            //Console.WriteLine(x);
            //string x = "1221435n";
            //int n = int.Parse(x);
            //int result;
            //bool  isNumber= int.TryParse(x,out result);
            //if (isNumber)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion

            #region Implicit,Explicit
            Manat manat = new Manat(510);
            Dollar dollar = (Dollar)manat;
            Console.WriteLine(dollar.Usd);
            #endregion
        }

        #region Implicit,Explicit
        class Manat
        {
            public double Azn { get; set; }
            public Manat(double azn)
            {
                Azn = azn;
            }

            public static explicit operator Dollar(Manat manat)
            {
                return new Dollar(manat.Azn / 1.7);
            }

            
        }

        class Dollar
        {
            public double Usd { get; set; }
            public Dollar(double usd)
            {
                Usd = usd;
            }

            public static explicit operator Manat(Dollar dollar)
            {
                return new Manat(dollar.Usd * 1.7);
            }
        }
        #endregion

        #region Casting
        abstract class Product
        {
            public int Id { get; set; }
            public double Price { get; set; }
            public string Title { get; set; }

            public abstract void Print();
        }

        abstract class Technology:Product
        {
            public string Brand { get; set; }
        }

        class Notebook:Technology
        {
            public int Ram { get; set; }
            public int SSD { get; set; }
            public override void Print()
            {
                Console.WriteLine("Notebook");
            }
        }

        abstract class Vegetable:Product
        {
            public double Kq { get; set; }
        }

        class Potato : Vegetable
        {
            public string Sort { get; set; }

            public override void Print()
            {
                Console.WriteLine("Potato");
            }
        }
        #endregion

        #region Struct
        //struct Area
        //{
        //    public int Length;
        //    public int Width;
        //    public Area(int length,int width)
        //    {
        //        Length = length;
        //        Width = width;
        //    }

        //    public void Test()
        //    {

        //    }
        //}
        #endregion

        #region Nullable value type
        //static void GetProduct(int? id)
        //{
        //    if(id is null)
        //    {
        //        Console.WriteLine("all product");
        //        return;
        //    }
        //    Console.WriteLine($"{id} id-li mehsul");
        //}
        #endregion
    }
}
