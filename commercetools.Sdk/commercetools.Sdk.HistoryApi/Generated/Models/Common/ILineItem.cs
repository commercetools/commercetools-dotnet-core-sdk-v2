using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.LineItem))]
    public partial interface ILineItem
    {
        string AddedAt { get; set; }

        ICustomFields Custom { get; set; }

        string Id { get; set; }

        ILocalizedString Name { get; set; }

        string ProductId { get; set; }

        ILocalizedString ProductSlug { get; set; }

        IReference ProductType { get; set; }

        int Quantity { get; set; }

        IVariant Variant { get; set; }

        int VariantId { get; set; }

    }
}
