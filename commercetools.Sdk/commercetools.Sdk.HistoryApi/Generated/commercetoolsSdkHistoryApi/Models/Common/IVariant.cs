using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Variant))]
    public partial interface IVariant
    {
        int Id { get; set; }

        string Sku { get; set; }

        string Key { get; set; }

    }
}
