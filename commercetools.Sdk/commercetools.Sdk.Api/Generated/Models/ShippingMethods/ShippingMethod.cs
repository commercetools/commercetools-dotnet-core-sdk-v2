using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethod : IShippingMethod
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public ILocalizedString LocalizedName { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public string Description { get; set; }

        public ILocalizedString LocalizedDescription { get; set; }

        public ITaxCategoryReference TaxCategory { get; set; }

        public List<IZoneRate> ZoneRates { get; set; }

        public bool IsDefault { get; set; }

        public string Predicate { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
