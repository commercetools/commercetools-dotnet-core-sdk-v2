using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCartTotalTaxAction))]
    public partial interface ICartSetCartTotalTaxAction : ICartUpdateAction
    {
        IMoney ExternalTotalGross { get; set; }

        List<ITaxPortionDraft> ExternalTaxPortions { get; set; }

    }
}
