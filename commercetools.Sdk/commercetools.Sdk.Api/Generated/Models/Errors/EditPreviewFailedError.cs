using commercetools.Api.Models.Errors;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class EditPreviewFailedError : IEditPreviewFailedError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public IOrderEditPreviewFailure Result { get; set;}
        public EditPreviewFailedError()
        { 
           this.Code = "EditPreviewFailed";
        }
    }
}
