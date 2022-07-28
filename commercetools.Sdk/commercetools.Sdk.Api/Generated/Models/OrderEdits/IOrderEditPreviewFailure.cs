using commercetools.Sdk.Api.Models.Errors;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditPreviewFailure))]
    public partial interface IOrderEditPreviewFailure : IOrderEditResult
    {
        List<IErrorObject> Errors { get; set; }

    }
}
