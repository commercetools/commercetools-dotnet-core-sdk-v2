using System;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ShoppingListLineItem : IShoppingListLineItem
    {
        public DateTime AddedAt { get; set; }

        public ICustomFields Custom { get; set; }

        public DateTime? DeactivatedAt { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public string ProductId { get; set; }

        public IProductTypeReference ProductType { get; set; }

        public bool Published { get; set; }

        public long Quantity { get; set; }

        public long? VariantId { get; set; }

        public IProductVariant Variant { get; set; }

        public ILocalizedString ProductSlug { get; set; }
    }
}
