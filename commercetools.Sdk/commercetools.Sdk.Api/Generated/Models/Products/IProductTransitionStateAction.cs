using commercetools.Sdk.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductTransitionStateAction))]
    public partial interface IProductTransitionStateAction : IProductUpdateAction
    {
        IStateResourceIdentifier State { get; set; }

        bool? Force { get; set; }
    }
}
