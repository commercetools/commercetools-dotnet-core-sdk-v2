using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.DiscountGroups;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountDraft : ICartDiscountDraft
    {
        public ILocalizedString Name { get; set; }

        public string Key { get; set; }

        public ILocalizedString Description { get; set; }

        public ICartDiscountValueDraft Value { get; set; }

        public string CartPredicate { get; set; }

        public ICartDiscountTarget Target { get; set; }

        public string SortOrder { get; set; }

        public IList<IStoreResourceIdentifier> Stores { get; set; }

        public IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }

        public bool? IsActive { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public bool? RequiresDiscountCode { get; set; }

        public IStackingMode StackingMode { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IDiscountGroupResourceIdentifier DiscountGroup { get; set; }
    }
}
