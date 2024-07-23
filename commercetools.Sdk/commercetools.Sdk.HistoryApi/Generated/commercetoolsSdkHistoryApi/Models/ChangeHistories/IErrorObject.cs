using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeHistories.ErrorObject))]
    public partial interface IErrorObject
    {
        string Code { get; set; }

        string Message { get; set; }

    }
}
