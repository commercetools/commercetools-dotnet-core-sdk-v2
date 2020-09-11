using commercetools.Api.Models.Errors;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class OrderEditPreviewFailure : OrderEditResult
    {
        public List<ErrorObject> Errors { get; set;}
    }
}
