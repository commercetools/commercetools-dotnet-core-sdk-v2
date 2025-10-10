using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Errors.ReferencedResourceNotFoundError))]
    public partial interface IReferencedResourceNotFoundError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string TypeId { get; set; }

        string Id { get; set; }

        string Key { get; set; }

    }
}
