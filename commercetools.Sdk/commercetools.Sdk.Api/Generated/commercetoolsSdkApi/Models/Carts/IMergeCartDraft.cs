using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.MergeCartDraft))]
    public partial interface IMergeCartDraft
    {
        ICartResourceIdentifier AnonymousCart { get; set; }

        ICartMergeMode MergeMode { get; set; }

        bool? UpdateProductData { get; set; }

        string AnonymousId { get; set; }

    }
}
