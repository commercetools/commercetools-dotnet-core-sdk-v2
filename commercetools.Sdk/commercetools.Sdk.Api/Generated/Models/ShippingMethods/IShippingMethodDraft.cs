using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


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

        List<IZoneRateDraft> ZoneRates { get; set; }

        bool IsDefault { get; set; }

        string Predicate { get; set; }

        ICustomFieldsDraft Custom { get; set; }
    }
}
