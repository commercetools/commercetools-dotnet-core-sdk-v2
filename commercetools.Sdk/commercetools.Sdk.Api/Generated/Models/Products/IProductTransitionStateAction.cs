using commercetools.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductTransitionStateAction))]
    public partial interface IProductTransitionStateAction : IProductUpdateAction
    {
        IStateResourceIdentifier State { get; set;}
        
        bool? Force { get; set;}
    }
}
