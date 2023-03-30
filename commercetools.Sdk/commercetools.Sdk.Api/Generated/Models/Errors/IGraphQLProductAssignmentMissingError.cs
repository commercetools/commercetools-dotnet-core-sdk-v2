using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLProductAssignmentMissingError))]
    public partial interface IGraphQLProductAssignmentMissingError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IProductReference Product { get; set; }

    }
}
