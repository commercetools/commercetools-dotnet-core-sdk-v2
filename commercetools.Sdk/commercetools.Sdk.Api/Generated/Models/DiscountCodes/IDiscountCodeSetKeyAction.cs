using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeSetKeyAction))]
    public partial interface IDiscountCodeSetKeyAction : IDiscountCodeUpdateAction
    {
        string Key { get; set; }

    }
}
