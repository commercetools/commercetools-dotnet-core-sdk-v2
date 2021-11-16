using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.ShippingMethodChangeValue))]
    public partial interface IShippingMethodChangeValue
    {
        string Id { get; set; }

        string Name { get; set; }
    }
}
