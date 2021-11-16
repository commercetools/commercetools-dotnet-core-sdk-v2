using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerCreatePasswordResetToken))]
    public partial interface ICustomerCreatePasswordResetToken 
    {
        string Email { get; set;}
        
        long? TtlMinutes { get; set;}
    }
}
