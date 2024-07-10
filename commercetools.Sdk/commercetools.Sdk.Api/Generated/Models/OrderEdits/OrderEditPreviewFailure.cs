using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
