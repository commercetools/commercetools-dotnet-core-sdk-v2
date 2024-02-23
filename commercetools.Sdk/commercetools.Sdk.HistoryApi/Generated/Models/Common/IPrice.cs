using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Price))]
    public partial interface IPrice
    {
        string Id { get; set; }

        IMoney Value { get; set; }

    }
}
