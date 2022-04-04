using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.RequiredFieldError))]
    public partial interface IRequiredFieldError : IErrorObject
    {
        string Field { get; set; }
    }
}
