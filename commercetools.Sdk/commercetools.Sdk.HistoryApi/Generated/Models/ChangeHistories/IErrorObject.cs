using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeHistories.ErrorObject))]
    public partial interface IErrorObject
    {
        string Code { get; set; }

        string Message { get; set; }
    }
}
