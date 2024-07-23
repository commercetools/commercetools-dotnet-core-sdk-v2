using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.ReturnItemDraft))]
    public partial interface IReturnItemDraft
    {
        long Quantity { get; set; }

        string LineItemId { get; set; }

        string CustomLineItemId { get; set; }

        string Comment { get; set; }

        IReturnShipmentState ShipmentState { get; set; }

    }
}
