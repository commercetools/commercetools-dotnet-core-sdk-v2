using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models
{
    public partial class ErrorObject : IErrorObject
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
    }
}
