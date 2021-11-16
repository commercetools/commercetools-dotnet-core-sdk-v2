using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerCreateEmailToken))]
    public partial interface ICustomerCreateEmailToken 
    {
        string Id { get; set;}
        
        long? Version { get; set;}
        
        long TtlMinutes { get; set;}
    }
}
