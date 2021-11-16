using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartChangeCustomLineItemMoneyAction))]
    public partial interface ICartChangeCustomLineItemMoneyAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set;}
        
        IMoney Money { get; set;}
    }
}
