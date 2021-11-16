using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Prices
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Prices.SubRate))]
    public partial interface ISubRate 
    {
        string Name { get; set;}
        
        double Amount { get; set;}
    }
}
