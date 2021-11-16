using System.Collections.Generic;


namespace commercetools.Api.Models.TaxCategories
{
    public partial class TaxRate : ITaxRate
    {
        public string Id { get; set;}
        
        public string Name { get; set;}
        
        public double Amount { get; set;}
        
        public bool IncludedInPrice { get; set;}
        
        public string Country { get; set;}
        
        public string State { get; set;}
        
        public List<ISubRate> SubRates { get; set;}
    }
}
