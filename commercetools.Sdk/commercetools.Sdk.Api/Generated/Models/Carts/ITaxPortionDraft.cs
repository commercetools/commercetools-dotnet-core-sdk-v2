using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.TaxPortionDraft))]
    public partial interface ITaxPortionDraft
    {
        string Name { get; set; }

        double Rate { get; set; }

        IMoney Amount { get; set; }
    }
}
