using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ErrorObject))]
    public partial interface IErrorObject
    {
        string Code { get; set; }

        string Message { get; set; }
    }
}
