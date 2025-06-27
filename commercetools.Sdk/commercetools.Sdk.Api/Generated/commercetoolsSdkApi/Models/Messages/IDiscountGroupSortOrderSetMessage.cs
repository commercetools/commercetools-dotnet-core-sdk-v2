using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DiscountGroupSortOrderSetMessage))]
    public partial interface IDiscountGroupSortOrderSetMessage : IMessage
    {
        string SortOrder { get; set; }

        string OldSortOrder { get; set; }

    }
}
