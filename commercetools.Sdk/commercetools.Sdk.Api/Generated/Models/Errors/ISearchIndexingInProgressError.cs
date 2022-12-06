using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.SearchIndexingInProgressError))]
    public partial interface ISearchIndexingInProgressError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
