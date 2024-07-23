using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetCustomTypeAction))]
    public partial interface IDiscountCodeSetCustomTypeAction : IDiscountCodeUpdateAction
    {
        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }

    }
}
