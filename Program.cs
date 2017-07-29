using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {


            BusPark BakuBus = new BusPark
            { 
                avtobuslar = new List<Bus>
                    {
                        new Bus
                        {
                            number = 7,
                            surucu = new Driver
                            {
                                ad="Vuqar"
                            }
                        },
                        new Bus
                        {
                            number = 88,
                            surucu =new Driver
                            {
                                ad="Ramin"
                            }
                        }
                    },
                yol = new List<RoutePath>
                {
                    new RoutePath
                    {
                        marshrut="Qara qarayev-nefciler",
                        kilometraj=7
                    },
                    new RoutePath
                    {
                        marshrut="28May-Sahil",
                        kilometraj=8
                    }
                }
            };



            //var input = Console.ReadLine();
            //var secilenler = BakuBus.avtobuslar.Find(f => f.surucu.ad == input);
            //if (secilenler != null)
            //{
            //    Console.WriteLine(secilenler.surucu.ad);
            //}
            //else
            //{
            //    Console.WriteLine("bu adda surucu yoxdu");
            //}



            var netice = BakuBus.avtobuslar.Join(BakuBus.yol, avt => avt.number, y=>y.kilometraj,
                (a,y)=>new Bus
            {
                number=y.kilometraj,
                surucu = new Driver()
                {
                    ad= y.marshrut
                }
                
            });

            Console.WriteLine("====");

            foreach (var cavab in netice)
            {
                Console.WriteLine(cavab.surucu.ad);
            }
           
            
            
            //    new BusPark
            //    {
            //        marshrut= new RoutePath
            //        {
            //            marshrut ="Qara-Qarayev"
            //        },
            //        number= new Bus                  
            //        {
            //            number = 12,

            //            ad= new Driver
            //            {
            //                ad= "Vuqar"
            //            }

            //        }
            //    },
            //    new BusPark
            //    {
            //        marshrut=new RoutePath
            //        {
            //            marshrut="28May"
            //        },
            //        number=new Bus
            //        {
            //            number=88,

            //            ad =new Driver
            //            {
            //                ad="Kamran"
            //            }
            //        },

            //    }
            //};

            //BusPark BakuBus = new BusPark();

            //OurBus.Add(BakuBus);


        }
    }
}
