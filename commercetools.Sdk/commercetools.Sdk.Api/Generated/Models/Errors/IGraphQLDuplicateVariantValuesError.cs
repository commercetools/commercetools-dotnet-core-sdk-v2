using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateVariantValuesError))]
    public partial interface IGraphQLDuplicateVariantValuesError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IVariantValues VariantValues { get; set; }

    }
}
