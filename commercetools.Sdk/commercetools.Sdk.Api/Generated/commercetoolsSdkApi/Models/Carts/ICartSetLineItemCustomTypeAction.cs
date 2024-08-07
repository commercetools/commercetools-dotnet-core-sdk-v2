using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemCustomTypeAction))]
    public partial interface ICartSetLineItemCustomTypeAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }

    }
}
