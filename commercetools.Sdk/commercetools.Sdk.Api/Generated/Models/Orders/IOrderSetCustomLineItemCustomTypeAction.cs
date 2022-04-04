using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetCustomLineItemCustomTypeAction))]
    public partial interface IOrderSetCustomLineItemCustomTypeAction : IOrderUpdateAction
    {
        string CustomLineItemId { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }
    }
}
