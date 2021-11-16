using commercetools.Api.Models.Messages;
using System.Collections.Generic;


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
