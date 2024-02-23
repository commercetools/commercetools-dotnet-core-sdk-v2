using commercetools.Sdk.Api.Models.Errors;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditPreviewFailure : IOrderEditPreviewFailure
    {
        public string Type { get; set; }

        public IList<IErrorObject> Errors { get; set; }
        public IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }

        public OrderEditPreviewFailure()
        {
            this.Type = "PreviewFailure";
        }
    }
}
