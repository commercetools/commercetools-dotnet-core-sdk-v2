using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.DiscountCodes
{

    public partial class DiscountCodeImport : IDiscountCodeImport
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public string Code { get; set; }

        public IList<ICartDiscountKeyReference> CartDiscounts { get; set; }
        public IEnumerable<ICartDiscountKeyReference> CartDiscountsEnumerable { set => CartDiscounts = value.ToList(); }


        public string CartPredicate { get; set; }

        public bool IsActive { get; set; }

        public long? MaxApplications { get; set; }

        public long? MaxApplicationsPerCustomer { get; set; }

        public IList<string> Groups { get; set; }
        public IEnumerable<string> GroupsEnumerable { set => Groups = value.ToList(); }


        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public ICustom Custom { get; set; }
    }
}
