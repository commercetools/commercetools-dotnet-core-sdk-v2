using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.InvalidJsonInputError))]
    public partial interface IInvalidJsonInputError : IErrorObject
    {
    }
}
