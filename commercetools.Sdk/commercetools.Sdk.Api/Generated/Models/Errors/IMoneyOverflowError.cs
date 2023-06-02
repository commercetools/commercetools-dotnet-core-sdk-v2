using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.MoneyOverflowError))]
    public partial interface IMoneyOverflowError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
