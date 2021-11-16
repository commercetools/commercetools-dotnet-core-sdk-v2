using commercetools.Api.Models.Errors;
using System.Collections.Generic;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditPreviewFailure : IOrderEditPreviewFailure
    {
        public string Type { get; set;}
        
        public List<IErrorObject> Errors { get; set;}
        public OrderEditPreviewFailure()
        { 
           this.Type = "PreviewFailure";
        }
    }
}
