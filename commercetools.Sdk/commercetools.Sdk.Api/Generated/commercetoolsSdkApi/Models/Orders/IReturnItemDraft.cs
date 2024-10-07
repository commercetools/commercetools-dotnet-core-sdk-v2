using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ReturnItemDraft))]
    public partial interface IReturnItemDraft
    {
        string Key { get; set; }

        long Quantity { get; set; }

        string LineItemId { get; set; }

        string CustomLineItemId { get; set; }

        string Comment { get; set; }

        IReturnShipmentState ShipmentState { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
