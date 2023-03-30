using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInternalConstraintViolatedError))]
    public partial interface IGraphQLInternalConstraintViolatedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
