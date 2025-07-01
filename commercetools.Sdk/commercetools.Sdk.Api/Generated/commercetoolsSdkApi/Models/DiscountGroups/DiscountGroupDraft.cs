using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.DiscountGroups
{

    public partial class DiscountGroupDraft : IDiscountGroupDraft
    {
        public ILocalizedString Name { get; set; }

        public string Key { get; set; }

        public ILocalizedString Description { get; set; }

        public string SortOrder { get; set; }
    }
}
