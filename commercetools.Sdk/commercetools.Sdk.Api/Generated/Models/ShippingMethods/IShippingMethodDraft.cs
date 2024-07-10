using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodDraft))]
    public partial interface IShippingMethodDraft
    {
        string Key { get; set; }

        string Name { get; set; }

        ILocalizedString LocalizedName { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        string Description { get; set; }

        ILocalizedString LocalizedDescription { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        IList<IZoneRateDraft> ZoneRates { get; set; }
        IEnumerable<IZoneRateDraft> ZoneRatesEnumerable { set => ZoneRates = value.ToList(); }


        bool IsDefault { get; set; }

        string Predicate { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
