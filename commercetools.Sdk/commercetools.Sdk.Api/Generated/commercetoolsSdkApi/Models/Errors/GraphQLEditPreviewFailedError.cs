using commercetools.Sdk.Api.Models.OrderEdits;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLEditPreviewFailedError : IGraphQLEditPreviewFailedError
    {
        public string Code { get; set; }

        public IOrderEditPreviewFailure Result { get; set; }
        public GraphQLEditPreviewFailedError()
        {
            this.Code = "EditPreviewFailed";
        }
    }
}
