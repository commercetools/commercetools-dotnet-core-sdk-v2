using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeHistories.ModifiedBy))]
    public partial interface IModifiedBy
    {
        bool IsPlatformClient { get; set; }

        string Id { get; set; }

        string Type { get; set; }

        string ClientId { get; set; }

        string AnonymousId { get; set; }

        IReference Customer { get; set; }

        IReference Associate { get; set; }

    }
}
