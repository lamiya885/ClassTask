using System.Net.Http.Headers;
using core.Helper.Enum;
using core.Helper.exceptions;
using core.Helper.Models;
using core.Helper.Models;

namespace EnumTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            string name;
            int price;
            Types type;
            Types tip;
            do
            {
                Console.WriteLine("0.Exit,1.Product elave et,2.filteredtype");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "0":
                        f = true;
                        break;
                    case "1":
                        {
                            Console.WriteLine("Produktubn adini daxil edin:");
                            name = Console.ReadLine();
                            Console.WriteLine("Qiymet daxil edin:");
                            bool a = int.TryParse(Console.ReadLine(), out price);
                            if (a = false)
                            {
                                Console.WriteLine("Duzgun qiymet daxil edin!");
                            }
                            Console.WriteLine("mehsulun tipini daxil edin:(1.baker,2.Drink,3.Meat ,4.Diary)");

                            string option = Console.ReadLine();
                            switch (option)
                            {
                                case "1":
                                    type = Types.Baker;
                                    break;
                                case "2":
                                    type = Types.Drink;
                                    break;
                                case "3":
                                    type = Types.Meat;
                                    break;
                                case "4":
                                    type = Types.Diary;
                                    break;
                                default:
                                    Console.WriteLine("dogru secim edin !");
                                    break;
                            }
                            Product product = new Product(name, price, type);

                        }
                        break;

                    case "2":
                        Console.WriteLine("1.baker,2.Drink,3.Meat ,4.Diary");
                        string operation2 = Console.ReadLine();
                        switch (operation2)
                        {
                            case "1":
                                tip = Types.Baker;
                                break;
                            case "2":
                                tip = Types.Drink;
                                break;
                            case "3":
                                tip = Types.Meat;
                                break;
                            case "4":
                                tip = Types.Diary;
                                break;
                            default:
                                Console.WriteLine("Duzgun secim edin!");
                                break;
                        }
                        Product[] products = Store.FilteredByType(tip);
                        break;


                    default:
                        Console.WriteLine("duzgun reqem daxil edin");
                        break;
                }

            } while (!f) ;
            
            
        }


    }

}
