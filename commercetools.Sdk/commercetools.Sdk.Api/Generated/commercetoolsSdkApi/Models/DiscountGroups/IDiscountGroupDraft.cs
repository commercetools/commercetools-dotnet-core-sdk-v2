using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupDraft))]
    public partial interface IDiscountGroupDraft
    {
        ILocalizedString Name { get; set; }

        string Key { get; set; }

        ILocalizedString Description { get; set; }

        string SortOrder { get; set; }

    }
}
