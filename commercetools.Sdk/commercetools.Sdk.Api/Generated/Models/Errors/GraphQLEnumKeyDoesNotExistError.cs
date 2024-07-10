namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLEnumKeyDoesNotExistError : IGraphQLEnumKeyDoesNotExistError
    {
        public string Code { get; set; }

        public string ConflictingEnumKey { get; set; }

        public string ConflictingAttributeName { get; set; }
        public GraphQLEnumKeyDoesNotExistError()
        {
            this.Code = "EnumKeyDoesNotExist";
        }
    }
}
