using System;
using System.Collections.Generic;
using System.Text;

namespace LottasLopper
{
    class ProductView
    {
        public List<Product> ProductList { get; set; }

        public ProductView()
        {
            this.ProductList = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            this.ProductList.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            this.ProductList.Remove(product);
        }

	    public void BuyProduct(Product product, string name)
	    {
            if (ProductList.Count >= 1)
	        {
	                var stringBuilder = StringBuilder(product, name);
	                Console.WriteLine(stringBuilder);
	                RemoveProduct(product);
	        }
		    else
		    {
			    Console.WriteLine("No products in stock");
		    }
	    }

        public StringBuilder StringBuilder(Product product, string name)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("\t\t\t\t\t" + name + " just bought product #" + product.ProductId + " from " +
                      product.SellerName);

            if (product.Dent || product.BasicFeatures || product.Customization || product.MissingPiece)
            {
                stringBuilder.Append(" with");
                if (product.Dent)
                {
                    stringBuilder.Append(" a minor dent");
                }

                if (product.BasicFeatures)
                {
                    if (product.Dent)
                    {
                        stringBuilder.Append(" and");
                    }

                    stringBuilder.Append(" basic features");
                }

                if (product.Customization)
                {
                    if (product.Dent || product.BasicFeatures)
                    {
                        stringBuilder.Append(" and");
                    }

                    stringBuilder.Append(" some customization");
                }

                if (product.MissingPiece)
                {
                    if (product.Dent || product.BasicFeatures || product.Customization)
                    {
                        stringBuilder.Append(" and");
                    }

                    stringBuilder.Append(" a missing piece");
                }
            }
            return stringBuilder;
        }
    }
}