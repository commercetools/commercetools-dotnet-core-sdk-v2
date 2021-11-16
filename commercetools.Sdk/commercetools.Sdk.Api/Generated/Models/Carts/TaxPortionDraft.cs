using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
{
    public partial class TaxPortionDraft : ITaxPortionDraft
    {
        public string Name { get; set;}
        
        public double Rate { get; set;}
        
        public IMoney Amount { get; set;}
    }
}
