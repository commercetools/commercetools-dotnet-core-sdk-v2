using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringSetKeyAction))]
    public partial interface IProductTailoringSetKeyAction : IProductTailoringUpdateAction
    {
        string Key { get; set; }

    }
}
