using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    public partial class ProductDiscount : IProductDiscount
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

        public IProductDiscountValue Value { get; set; }

        public string Predicate { get; set; }

        public string SortOrder { get; set; }

        public bool IsActive { get; set; }

        public List<IReference> References { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }
    }
}
