namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLAttributeNameDoesNotExistError : IGraphQLAttributeNameDoesNotExistError
    {
        public string Code { get; set; }

        public string InvalidAttributeName { get; set; }
        public GraphQLAttributeNameDoesNotExistError()
        {
            this.Code = "AttributeNameDoesNotExist";
        }
    }
}
