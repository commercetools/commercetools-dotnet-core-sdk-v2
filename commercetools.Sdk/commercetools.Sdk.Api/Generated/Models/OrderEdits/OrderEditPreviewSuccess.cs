using commercetools.Sdk.Api.Models.Messages;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.OrderEdits
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
