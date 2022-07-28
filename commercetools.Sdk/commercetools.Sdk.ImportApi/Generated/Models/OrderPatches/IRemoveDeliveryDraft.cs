using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.RemoveDeliveryDraft))]
    public partial interface IRemoveDeliveryDraft
    {
        string Id { get; set; }

    }
}
