using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicatePriceKeyError))]
    public partial interface IGraphQLDuplicatePriceKeyError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IPrice ConflictingPrice { get; set; }

    }
}
