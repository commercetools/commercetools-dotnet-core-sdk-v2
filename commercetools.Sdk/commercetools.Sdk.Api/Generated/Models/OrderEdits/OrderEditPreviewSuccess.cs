using commercetools.Api.Models.Messages;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditPreviewSuccess : IOrderEditPreviewSuccess
    {
        public string Type { get; set; }

        public IStagedOrder Preview { get; set; }

        public List<IMessagePayload> MessagePayloads { get; set; }
        public OrderEditPreviewSuccess()
        {
            this.Type = "PreviewSuccess";
        }
    }
}
