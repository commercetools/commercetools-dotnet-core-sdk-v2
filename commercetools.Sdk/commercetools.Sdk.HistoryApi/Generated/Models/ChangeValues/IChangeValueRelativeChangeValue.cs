using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeValueRelativeChangeValue))]
    public partial interface IChangeValueRelativeChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set; }

        int Permyriad { get; set; }

    }
}
