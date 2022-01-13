using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.SearchExecutionFailureError))]
    public partial interface ISearchExecutionFailureError : IErrorObject
    {
    }
}
