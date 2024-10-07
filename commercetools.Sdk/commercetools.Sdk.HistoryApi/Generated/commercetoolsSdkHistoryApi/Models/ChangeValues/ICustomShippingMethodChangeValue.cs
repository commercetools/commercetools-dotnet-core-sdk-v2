using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.CustomShippingMethodChangeValue))]
    public partial interface ICustomShippingMethodChangeValue
    {
        string Name { get; set; }

    }
}
