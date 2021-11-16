using commercetools.Api.Models.Common;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodDraft : IShippingMethodDraft
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public ILocalizedString LocalizedName { get; set; }

        public string Description { get; set; }

        public ILocalizedString LocalizedDescription { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public List<IZoneRateDraft> ZoneRates { get; set; }

        public bool IsDefault { get; set; }

        public string Predicate { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
