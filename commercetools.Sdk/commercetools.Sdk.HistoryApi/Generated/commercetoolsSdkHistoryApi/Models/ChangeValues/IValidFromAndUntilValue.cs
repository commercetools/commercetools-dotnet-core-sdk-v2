using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ValidFromAndUntilValue))]
    public partial interface IValidFromAndUntilValue
    {
        string ValidFrom { get; set; }

        string ValidUntil { get; set; }

    }
}
