using commercetools.Api.Models.Errors;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public  partial class OrderEditPreviewFailure : IOrderEditPreviewFailure
    {
        public string Type { get; set;}
        
        public List<IErrorObject> Errors { get; set;}
        public OrderEditPreviewFailure()
        { 
           this.Type = "PreviewFailure";
        }
    }
}
