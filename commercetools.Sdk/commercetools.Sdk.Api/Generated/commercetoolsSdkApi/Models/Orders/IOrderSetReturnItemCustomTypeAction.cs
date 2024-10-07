using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetReturnItemCustomTypeAction))]
    public partial interface IOrderSetReturnItemCustomTypeAction : IOrderUpdateAction
    {
        string ReturnItemId { get; set; }

        string ReturnItemKey { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }

    }
}
