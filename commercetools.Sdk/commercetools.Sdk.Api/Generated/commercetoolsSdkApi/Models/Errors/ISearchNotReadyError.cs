using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.SearchNotReadyError))]
    public partial interface ISearchNotReadyError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
