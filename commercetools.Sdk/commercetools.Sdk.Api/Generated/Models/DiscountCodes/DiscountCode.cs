using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCode : IDiscountCode
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public string Code { get; set; }

        public List<ICartDiscountReference> CartDiscounts { get; set; }

        public string CartPredicate { get; set; }

        public bool IsActive { get; set; }

        public List<IReference> References { get; set; }

        public long? MaxApplications { get; set; }

        public long? MaxApplicationsPerCustomer { get; set; }

        public ICustomFields Custom { get; set; }

        public List<string> Groups { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public long? ApplicationVersion { get; set; }
    }
}
