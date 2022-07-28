using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerAddAddressAction))]
    public partial interface ICustomerAddAddressAction : ICustomerUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
