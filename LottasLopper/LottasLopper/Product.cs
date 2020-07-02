
namespace LottasLopper
{
    class Product
	{
	    public int ProductId { get; set; }
	    public string SellerName { get; set; }
	    public bool Dent { get; set; }
	    public bool Customization { get; set; }
	    public bool BasicFeatures { get; set; }
	    public bool MissingPiece { get; set; }

	    public Product(int productId, string sellerName, bool dent, 
	                   bool customization, bool basicFeatures, bool missingPiece)
	    {
	        this.ProductId = productId;
	        this.SellerName = sellerName;
	        this.Dent = dent;
	        this.Customization = customization;
	        this.BasicFeatures = basicFeatures;
	        this.MissingPiece = missingPiece;
	    }
	}
}