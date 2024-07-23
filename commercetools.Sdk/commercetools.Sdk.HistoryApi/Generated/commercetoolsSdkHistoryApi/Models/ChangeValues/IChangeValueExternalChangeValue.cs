using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueExternalChangeValue))]
    public partial interface IChangeValueExternalChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set; }

    }
}
