using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    public partial class ErrorResponse : IErrorResponse
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public string Error { get; set; }

        public string Error_description { get; set; }

        public List<IErrorObject> Errors { get; set; }
    }
}
