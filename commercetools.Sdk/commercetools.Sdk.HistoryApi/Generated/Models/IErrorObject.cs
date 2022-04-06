using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ErrorObject))]
    public partial interface IErrorObject
    {
        string Code { get; set; }

        string Message { get; set; }
    }
}
