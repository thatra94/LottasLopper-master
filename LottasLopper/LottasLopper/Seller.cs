using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LottasLopper
{
	class Seller
	{
		public string Name { get; set; }
		public int ProductCount { get; set; }

		public Seller(string name)
		{
			this.Name = name;
		}
		public Product RegisterProduct(bool dent, bool customization, bool basicFeatures, bool missingPiece)
		{
            ProductCount++;
            var product = new Product(ProductCount, Name, dent, customization, basicFeatures, missingPiece);
		    Console.WriteLine(Name + " puts item #" + ProductCount + " up for sale");
			return product;
		}
	}
}
