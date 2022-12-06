using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeDraft : IDiscountCodeDraft
    {
        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public string Code { get; set; }

        public IList<ICartDiscountResourceIdentifier> CartDiscounts { get; set; }
        public IEnumerable<ICartDiscountResourceIdentifier> CartDiscountsEnumerable { set => CartDiscounts = value.ToList(); }


        public string CartPredicate { get; set; }

        public bool? IsActive { get; set; }

        public long? MaxApplications { get; set; }

        public long? MaxApplicationsPerCustomer { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IList<string> Groups { get; set; }
        public IEnumerable<string> GroupsEnumerable { set => Groups = value.ToList(); }


        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }
    }
}
