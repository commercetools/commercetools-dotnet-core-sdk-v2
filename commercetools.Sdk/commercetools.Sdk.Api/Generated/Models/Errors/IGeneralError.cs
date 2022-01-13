using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.GeneralError))]
    public partial interface IGeneralError : IErrorObject
    {
    }
}
