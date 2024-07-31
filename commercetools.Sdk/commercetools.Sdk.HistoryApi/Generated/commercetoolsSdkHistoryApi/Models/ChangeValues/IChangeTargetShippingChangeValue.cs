using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetShippingChangeValue))]
    public partial interface IChangeTargetShippingChangeValue : IChangeTargetChangeValue
    {
        new string Type { get; set; }

    }
}
