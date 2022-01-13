using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.QueryComplexityLimitExceededError))]
    public partial interface IQueryComplexityLimitExceededError : IErrorObject
    {
    }
}
