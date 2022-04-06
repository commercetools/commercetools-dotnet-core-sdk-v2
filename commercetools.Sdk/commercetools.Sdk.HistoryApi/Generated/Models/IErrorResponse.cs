using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ErrorResponse))]
    public partial interface IErrorResponse
    {
        int StatusCode { get; set; }

        string Message { get; set; }

        string Error { get; set; }

        string Error_description { get; set; }

        List<IErrorObject> Errors { get; set; }
    }
}
