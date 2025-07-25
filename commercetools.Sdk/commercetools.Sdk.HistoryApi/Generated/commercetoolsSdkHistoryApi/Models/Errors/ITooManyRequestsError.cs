using commercetools.Sdk.HistoryApi.Models.ChangeHistories;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Errors.TooManyRequestsError))]
    public partial interface ITooManyRequestsError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
