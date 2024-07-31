using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ProductAssignmentMissingError))]
    public partial interface IProductAssignmentMissingError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IProductReference Product { get; set; }

    }
}
