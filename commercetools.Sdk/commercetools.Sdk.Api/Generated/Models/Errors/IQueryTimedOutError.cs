using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.QueryTimedOutError))]
    public partial interface IQueryTimedOutError : IErrorObject
    {
    }
}
