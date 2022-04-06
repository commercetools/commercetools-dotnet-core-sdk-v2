using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.CustomShippingMethodChangeValue))]
    public partial interface ICustomShippingMethodChangeValue
    {
        string Name { get; set; }
    }
}
