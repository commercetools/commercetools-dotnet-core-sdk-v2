using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.RequiredFieldError))]
    public partial interface IRequiredFieldError : IErrorObject
    {
        string Field { get; set; }
    }
}
