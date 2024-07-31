using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscount : ICartDiscount
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public ILocalizedString Name { get; set; }

        public string Key { get; set; }

        public ILocalizedString Description { get; set; }

        public ICartDiscountValue Value { get; set; }

        public string CartPredicate { get; set; }

        public ICartDiscountTarget Target { get; set; }

        public string SortOrder { get; set; }

        public IList<IStoreKeyReference> Stores { get; set; }

        public IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }

        public bool IsActive { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public bool RequiresDiscountCode { get; set; }

        public IList<IReference> References { get; set; }

        public IEnumerable<IReference> ReferencesEnumerable { set => References = value.ToList(); }

        public IStackingMode StackingMode { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
