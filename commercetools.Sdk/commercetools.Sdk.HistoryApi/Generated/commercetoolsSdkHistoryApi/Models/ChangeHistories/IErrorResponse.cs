using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
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
