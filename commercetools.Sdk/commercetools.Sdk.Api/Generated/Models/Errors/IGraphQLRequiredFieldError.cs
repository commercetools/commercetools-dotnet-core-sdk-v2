using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLRequiredFieldError))]
    public partial interface IGraphQLRequiredFieldError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string Field { get; set; }

    }
}
