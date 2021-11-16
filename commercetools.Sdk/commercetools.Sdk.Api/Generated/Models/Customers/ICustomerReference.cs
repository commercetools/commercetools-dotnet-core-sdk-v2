using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerReference))]
    public partial interface ICustomerReference : IReference
    {
        ICustomer Obj { get; set;}
    }
}
