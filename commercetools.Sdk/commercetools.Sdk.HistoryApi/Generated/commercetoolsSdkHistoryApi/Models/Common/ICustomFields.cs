using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.CustomFields))]
    public partial interface ICustomFields
    {
        ITypeReference Type { get; set; }

        IFieldContainer Fields { get; set; }

    }
}
