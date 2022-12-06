using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethod))]
    public partial interface IShippingMethod : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Key { get; set; }

        string Name { get; set; }

        ILocalizedString LocalizedName { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        string Description { get; set; }

        ILocalizedString LocalizedDescription { get; set; }

        ITaxCategoryReference TaxCategory { get; set; }

        IList<IZoneRate> ZoneRates { get; set; }
        IEnumerable<IZoneRate> ZoneRatesEnumerable { set => ZoneRates = value.ToList(); }


        bool IsDefault { get; set; }

        string Predicate { get; set; }

        ICustomFields Custom { get; set; }

    }
}
