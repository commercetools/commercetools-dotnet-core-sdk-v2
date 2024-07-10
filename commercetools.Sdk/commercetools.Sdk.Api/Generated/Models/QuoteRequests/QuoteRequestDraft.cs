using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestDraft : IQuoteRequestDraft
    {
        public ICartResourceIdentifier Cart { get; set; }

        public long CartVersion { get; set; }

        public string Key { get; set; }

        public string Comment { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IStateReference State { get; set; }

        public string PurchaseOrderNumber { get; set; }
    }
}
