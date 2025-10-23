using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.StateReference))]
    public partial interface IStateReference : IReference
    {
        new string Id { get; set; }

    }
}
