using commercetools.HistoryApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models
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
