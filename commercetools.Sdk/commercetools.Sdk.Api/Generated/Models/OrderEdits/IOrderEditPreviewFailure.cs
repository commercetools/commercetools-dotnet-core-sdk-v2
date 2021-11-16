using commercetools.Api.Models.Errors;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditPreviewFailure))]
    public partial interface IOrderEditPreviewFailure : IOrderEditResult
    {
        List<IErrorObject> Errors { get; set; }
    }
}
