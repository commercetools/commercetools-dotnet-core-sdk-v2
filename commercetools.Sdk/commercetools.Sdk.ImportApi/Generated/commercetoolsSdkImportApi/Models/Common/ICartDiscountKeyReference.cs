using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.CartDiscountKeyReference))]
    public partial interface ICartDiscountKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
