using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GeneralError))]
    public partial interface IGeneralError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
