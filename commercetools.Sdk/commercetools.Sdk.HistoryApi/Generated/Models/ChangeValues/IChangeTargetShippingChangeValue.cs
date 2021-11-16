using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeTargetShippingChangeValue))]
    public partial interface IChangeTargetShippingChangeValue : IChangeTargetChangeValue
    {
        new string Type { get; set;}
    }
}
