using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderResourceIdentifier))]
    public partial interface IOrderResourceIdentifier : IResourceIdentifier
    {
    }
}
