using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemMoneyAction))]
    public partial interface ICartChangeCustomLineItemMoneyAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        IMoney Money { get; set; }
    }
}
