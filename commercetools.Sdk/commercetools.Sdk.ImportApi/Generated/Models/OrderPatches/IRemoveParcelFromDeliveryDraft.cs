using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.RemoveParcelFromDeliveryDraft))]
    public partial interface IRemoveParcelFromDeliveryDraft
    {
        string ParcelId { get; set; }

    }
}
