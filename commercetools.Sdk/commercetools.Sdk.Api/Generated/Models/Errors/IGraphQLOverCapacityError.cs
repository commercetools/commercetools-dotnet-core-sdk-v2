using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLOverCapacityError))]
    public partial interface IGraphQLOverCapacityError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
