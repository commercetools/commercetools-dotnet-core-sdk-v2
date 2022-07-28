using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.TaxPortionDraft))]
    public partial interface ITaxPortionDraft
    {
        string Name { get; set; }

        decimal Rate { get; set; }

        IMoney Amount { get; set; }

    }
}
