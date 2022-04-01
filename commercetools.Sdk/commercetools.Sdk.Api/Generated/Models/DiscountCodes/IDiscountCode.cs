using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCode))]
    public partial interface IDiscountCode : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        string Code { get; set; }

        List<ICartDiscountReference> CartDiscounts { get; set; }

        string CartPredicate { get; set; }

        bool IsActive { get; set; }

        List<IReference> References { get; set; }

        long? MaxApplications { get; set; }

        long? MaxApplicationsPerCustomer { get; set; }

        ICustomFields Custom { get; set; }

        List<string> Groups { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        long? ApplicationVersion { get; set; }
    }
}
