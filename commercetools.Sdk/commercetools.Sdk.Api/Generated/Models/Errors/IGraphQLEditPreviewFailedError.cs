using commercetools.Sdk.Api.Models.OrderEdits;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLEditPreviewFailedError))]
    public partial interface IGraphQLEditPreviewFailedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IOrderEditPreviewFailure Result { get; set; }

    }
}
