using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeDraft))]
    public partial interface IDiscountCodeDraft
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        string Code { get; set; }

        List<ICartDiscountResourceIdentifier> CartDiscounts { get; set; }

        string CartPredicate { get; set; }

        bool? IsActive { get; set; }

        long? MaxApplications { get; set; }

        long? MaxApplicationsPerCustomer { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        List<string> Groups { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

    }
}
