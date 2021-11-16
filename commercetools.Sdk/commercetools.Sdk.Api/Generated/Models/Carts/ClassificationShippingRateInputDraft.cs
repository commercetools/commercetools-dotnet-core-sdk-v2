namespace commercetools.Api.Models.Carts
{
    public partial class ClassificationShippingRateInputDraft : IClassificationShippingRateInputDraft
    {
        public string Type { get; set;}
        
        public string Key { get; set;}
        public ClassificationShippingRateInputDraft()
        { 
           this.Type = "Classification";
        }
    }
}
