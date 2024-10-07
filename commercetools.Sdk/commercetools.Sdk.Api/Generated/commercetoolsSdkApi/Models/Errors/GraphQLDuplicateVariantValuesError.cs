namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLDuplicateVariantValuesError : IGraphQLDuplicateVariantValuesError
    {
        public string Code { get; set; }

        public IVariantValues VariantValues { get; set; }
        public GraphQLDuplicateVariantValuesError()
        {
            this.Code = "DuplicateVariantValues";
        }
    }
}
