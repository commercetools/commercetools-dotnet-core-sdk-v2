using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCode))]
    public partial interface IDiscountCode : IBaseResource
    {
        new string Id { get; set; }

        string Key { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        string Code { get; set; }

        IList<ICartDiscountReference> CartDiscounts { get; set; }

        IEnumerable<ICartDiscountReference> CartDiscountsEnumerable { set => CartDiscounts = value.ToList(); }

        string CartPredicate { get; set; }

        bool IsActive { get; set; }

        IList<IReference> References { get; set; }

        IEnumerable<IReference> ReferencesEnumerable { set => References = value.ToList(); }

        long? MaxApplications { get; set; }

        long? MaxApplicationsPerCustomer { get; set; }

        ICustomFields Custom { get; set; }

        IList<string> Groups { get; set; }

        IEnumerable<string> GroupsEnumerable { set => Groups = value.ToList(); }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        long? ApplicationVersion { get; set; }

    }
}
