using commercetools.Sdk.HistoryApi.Models.ChangeHistories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeHistories.ErrorResponse))]
    public partial interface IErrorResponse
    {
        int StatusCode { get; set; }

        string Message { get; set; }

        string Error { get; set; }

        string Error_description { get; set; }

        IList<IErrorObject> Errors { get; set; }
        IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }


    }
}
