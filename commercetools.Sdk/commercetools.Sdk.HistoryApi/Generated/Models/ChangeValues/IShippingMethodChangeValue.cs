using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ShippingMethodChangeValue))]
    public partial interface IShippingMethodChangeValue
    {
        string Id { get; set; }

        string Name { get; set; }
    }
}
