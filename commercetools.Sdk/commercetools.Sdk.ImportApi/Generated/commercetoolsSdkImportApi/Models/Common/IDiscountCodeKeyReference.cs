using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.DiscountCodeKeyReference))]
    public partial interface IDiscountCodeKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
