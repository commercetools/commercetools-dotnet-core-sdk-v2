using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeHistories.ModifiedBy))]
    public partial interface IModifiedBy
    {
        string Id { get; set; }

        string Type { get; set; }

        IReference Customer { get; set; }

        string AnonymousId { get; set; }

        string ClientId { get; set; }

        bool IsPlatformClient { get; set; }
    }
}
