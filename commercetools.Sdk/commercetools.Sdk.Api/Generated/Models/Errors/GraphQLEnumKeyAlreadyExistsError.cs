namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLEnumKeyAlreadyExistsError : IGraphQLEnumKeyAlreadyExistsError
    {
        public string Code { get; set; }

        public string ConflictingEnumKey { get; set; }

        public string ConflictingAttributeName { get; set; }
        public GraphQLEnumKeyAlreadyExistsError()
        {
            this.Code = "EnumKeyAlreadyExists";
        }
    }
}
