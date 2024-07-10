using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class Transaction : ITransaction
    {
        public string Id { get; set; }

        public DateTime? Timestamp { get; set; }

        public ITransactionType Type { get; set; }

        public ICentPrecisionMoney Amount { get; set; }

        public string InteractionId { get; set; }

        public ITransactionState State { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
