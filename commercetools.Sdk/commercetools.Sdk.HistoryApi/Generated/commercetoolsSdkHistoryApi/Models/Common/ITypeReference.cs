using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.TypeReference))]
    public partial interface ITypeReference : IReference
    {
        new string Id { get; set; }

    }
}
