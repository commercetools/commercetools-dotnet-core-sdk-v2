using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class EditPreviewFailedError : IEditPreviewFailedError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IOrderEditPreviewFailure Result { get; set; }
        public EditPreviewFailedError()
        {
            this.Code = "EditPreviewFailed";
        }
    }
}
