using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.EnumValuesMustMatchError))]
    public partial interface IEnumValuesMustMatchError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
