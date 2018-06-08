using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7._7_4_
{
    class Stock
    {
        public delegate void PriceChange(double price);
        public event PriceChange PriceRiseEvent;
        public event PriceChange PriceDownEvent;
        public string StockName
        {
            get;
            set;
        }
        public double StockPrice
        {
            get;
            set;
        }
        public Stock(string stockName, double price)
        {
            StockName = stockName;
            StockPrice = price;
        }
        public void PriceRise(double up)
        {
            Console.WriteLine("股票价格升高了{0}%", up * 100.0 / StockPrice);
            PriceRiseEvent(up);
            StockPrice += up;
        }
        public void PriceDown(double down)
        {
            Console.WriteLine("股票价格降低了{0}%", down * 100.0 / StockPrice);
            PriceDownEvent(down);
            StockPrice -= down;
        }
    }

    class Buyer
    {
        private Stock stock;
        public void StockPriceRise(double up)
        {
            if (up / stock.StockPrice >= 0.05)
            {
                Console.WriteLine("股票上涨已经超过5%，买家请谨慎买入");
            }
            else
            {
                Console.WriteLine("股票正小幅上涨，买家可以买入");
            }
        }
        public void StockPriceDown(double down)
        {
            if (down / stock.StockPrice >= 0.05)
            {
                Console.WriteLine("股票下跌已经超过5%，买家可以逢低买入");
            }
            else
            {
                Console.WriteLine("股票正小幅下跌，买家暂时请观望");
            }
        }
        public Buyer(Stock stock)
        {
            this.stock = stock;
        }
    }

    class Seller
    {
        private Stock stock;
        public void StockPriceRise(double up)
        {
            if (up / stock.StockPrice >= 0.05)
            {
                Console.WriteLine("股票上涨已经超过5%，卖家请赶快抛售");
            }
            else
            {
                Console.WriteLine("股票正小幅上涨，卖家请继续观望");
            }
        }
        public void StockPriceDown(double down)
        {
            if (down / stock.StockPrice >= 0.05)
            {
                Console.WriteLine("股票下跌已经超过5%，卖家请逢低补仓");
            }
            else
            { Console.WriteLine("股票正小幅下跌，卖家请谨慎操作");
            }
        }
        public Seller(Stock stock)
        {
            this.stock = stock;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("哔哩哔哩", 2.33);
            Buyer buyer = new Buyer(stock);
            Seller seller = new Seller(stock);
            stock.PriceDownEvent += buyer.StockPriceDown;
            stock.PriceDownEvent += seller.StockPriceDown;
            stock.PriceRiseEvent += buyer.StockPriceRise;
            stock.PriceRiseEvent += seller.StockPriceRise;
            stock.PriceRise(0.8);
            stock.PriceDown(1.2);

        }
    }
}


