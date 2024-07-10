namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLEnumValuesMustMatchError : IGraphQLEnumValuesMustMatchError
    {
        public string Code { get; set; }
        public GraphQLEnumValuesMustMatchError()
        {
            this.Code = "EnumValuesMustMatch";
        }
    }
}
