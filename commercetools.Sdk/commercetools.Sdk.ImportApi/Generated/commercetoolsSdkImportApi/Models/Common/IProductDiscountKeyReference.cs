using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.ProductDiscountKeyReference))]
    public partial interface IProductDiscountKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
