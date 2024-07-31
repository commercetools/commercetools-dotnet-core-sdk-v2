using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCode : IDiscountCode
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public string Key { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public string Code { get; set; }

        public IList<ICartDiscountReference> CartDiscounts { get; set; }

        public IEnumerable<ICartDiscountReference> CartDiscountsEnumerable { set => CartDiscounts = value.ToList(); }

        public string CartPredicate { get; set; }

        public bool IsActive { get; set; }

        public IList<IReference> References { get; set; }

        public IEnumerable<IReference> ReferencesEnumerable { set => References = value.ToList(); }

        public long? MaxApplications { get; set; }

        public long? MaxApplicationsPerCustomer { get; set; }

        public ICustomFields Custom { get; set; }

        public IList<string> Groups { get; set; }

        public IEnumerable<string> GroupsEnumerable { set => Groups = value.ToList(); }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public long? ApplicationVersion { get; set; }
    }
}
