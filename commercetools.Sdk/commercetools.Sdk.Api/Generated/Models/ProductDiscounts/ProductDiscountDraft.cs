using commercetools.Sdk.Api.Models.Common;
using System;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountDraft : IProductDiscountDraft
    {
        public ILocalizedString Name { get; set; }

        public string Key { get; set; }

        public ILocalizedString Description { get; set; }

        public IProductDiscountValueDraft Value { get; set; }

        public string Predicate { get; set; }

        public string SortOrder { get; set; }

        public bool IsActive { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }
    }
}
