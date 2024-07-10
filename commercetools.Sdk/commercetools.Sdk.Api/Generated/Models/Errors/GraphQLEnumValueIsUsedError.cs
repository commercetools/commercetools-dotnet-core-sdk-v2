namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLEnumValueIsUsedError : IGraphQLEnumValueIsUsedError
    {
        public string Code { get; set; }
        public GraphQLEnumValueIsUsedError()
        {
            this.Code = "EnumValueIsUsed";
        }
    }
}
