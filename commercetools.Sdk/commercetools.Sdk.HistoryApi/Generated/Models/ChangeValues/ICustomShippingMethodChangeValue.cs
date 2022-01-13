using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.CustomShippingMethodChangeValue))]
    public partial interface ICustomShippingMethodChangeValue
    {
        string Name { get; set; }
    }
}
