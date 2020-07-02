using System;
using System.Diagnostics;
using System.Threading;

namespace LottasLopper
{
    class Program
    {
        private static ProductView _productView = new ProductView();
        private static bool exitBool { get; set; }
        private readonly static object _buyLock = new object();
        private readonly static object _sellLock = new object();
        private readonly static Random _rand = new Random();

        public static void Main(string[] args)
        {
            Console.SetWindowSize(150, 35);
            Console.WriteLine("\n*Hit 'enter' to exit after simulation has completed*\n\n");
            exitBool = true;

            var sellerThread1 = new Thread(() => AddProductSimulation(new Seller("Lotte")));
            var sellerThread2 = new Thread(() => AddProductSimulation(new Seller("Erlend")));
            sellerThread1.Start();
            sellerThread2.Start();

            var buyerThread1 = new Thread(() => BuyProductsSimulation(new Buyer("Fredrik")));
            var buyerThread2 = new Thread(() => BuyProductsSimulation(new Buyer("Thanh")));
            buyerThread1.Start();
            buyerThread2.Start();

            Console.ReadLine();
        }

        public static void AddProductSimulation(Seller seller)
        {
            for (var i = 0; i < 6; i++)
            {
                lock (_sellLock)
                {
                    int product = _rand.Next(1, 6);

                    switch (product)
                    {
                        case 1:
                            _productView.AddProduct(seller.RegisterProduct(true, true, false, false));
                            break;
                        case 2:
                            _productView.AddProduct(seller.RegisterProduct(false, false, true, false));
                            break;
                        case 3:
                            _productView.AddProduct(seller.RegisterProduct(true, true, false, true));
                            break;
                        case 4:
                            _productView.AddProduct(seller.RegisterProduct(false, true, false, false));
                            break;
                        case 5:
                            _productView.AddProduct(seller.RegisterProduct(false, true, true, false));
                            break;
                        case 6:
                            _productView.AddProduct(seller.RegisterProduct(true, true, true, true));
                            break;
                    }
                }

                Thread.Sleep(3000);
            }

            exitBool = false;
        }

        public static void BuyProductsSimulation(Buyer buyer)
        {
            while (exitBool)
            {
                lock (_buyLock)
                {
                    if (_productView.ProductList.Count > 0)
                    {
                        _productView.BuyProduct(_productView.ProductList[0], buyer.Name);
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}

