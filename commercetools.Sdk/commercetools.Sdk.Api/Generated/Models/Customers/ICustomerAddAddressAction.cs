using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerAddAddressAction))]
    public partial interface ICustomerAddAddressAction : ICustomerUpdateAction
    {
        IBaseAddress Address { get; set;}
    }
}
