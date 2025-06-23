using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DiscountGroupSortOrderSetMessagePayload))]
    public partial interface IDiscountGroupSortOrderSetMessagePayload : IMessagePayload
    {
        string SortOrder { get; set; }

        string OldSortOrder { get; set; }

    }
}
