using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditPreviewSuccess : IOrderEditPreviewSuccess
    {
        public string Type { get; set; }

        public IStagedOrder Preview { get; set; }

        public IList<IMessagePayload> MessagePayloads { get; set; }
        public IEnumerable<IMessagePayload> MessagePayloadsEnumerable { set => MessagePayloads = value.ToList(); }

        public OrderEditPreviewSuccess()
        {
            this.Type = "PreviewSuccess";
        }
    }
}
