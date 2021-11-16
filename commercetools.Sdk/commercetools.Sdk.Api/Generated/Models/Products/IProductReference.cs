using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductReference))]
    public partial interface IProductReference : IReference
    {
        IProduct Obj { get; set; }
    }
}
