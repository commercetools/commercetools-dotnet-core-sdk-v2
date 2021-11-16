using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeReference))]
    public partial interface IProductTypeReference : IReference
    {
        IProductType Obj { get; set;}
    }
}
