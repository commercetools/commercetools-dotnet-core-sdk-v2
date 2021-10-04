using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodDraft))]
    public partial interface IShippingMethodDraft
    {
        string Key { get; set; }

        string Name { get; set; }

        ILocalizedString LocalizedName { get; set; }

        string Description { get; set; }

        ILocalizedString LocalizedDescription { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        List<IZoneRateDraft> ZoneRates { get; set; }

        bool IsDefault { get; set; }

        string Predicate { get; set; }

        ICustomFieldsDraft Custom { get; set; }
    }
}
