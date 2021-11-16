using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerResourceIdentifier))]
    public partial interface ICustomerResourceIdentifier : IResourceIdentifier
    {
    }
}
