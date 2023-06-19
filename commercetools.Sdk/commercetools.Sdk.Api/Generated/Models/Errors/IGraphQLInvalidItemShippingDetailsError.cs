using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidItemShippingDetailsError))]
    public partial interface IGraphQLInvalidItemShippingDetailsError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string Subject { get; set; }

        string ItemId { get; set; }

    }
}
