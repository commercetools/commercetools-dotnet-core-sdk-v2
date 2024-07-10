using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeDraft))]
    public partial interface IDiscountCodeDraft
    {
        string Key { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        string Code { get; set; }

        IList<ICartDiscountResourceIdentifier> CartDiscounts { get; set; }
        IEnumerable<ICartDiscountResourceIdentifier> CartDiscountsEnumerable { set => CartDiscounts = value.ToList(); }


        string CartPredicate { get; set; }

        bool? IsActive { get; set; }

        long? MaxApplications { get; set; }

        long? MaxApplicationsPerCustomer { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IList<string> Groups { get; set; }
        IEnumerable<string> GroupsEnumerable { set => Groups = value.ToList(); }


        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

    }
}
