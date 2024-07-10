using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Me;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyPaymentDraft : IMyPaymentDraft
    {
        public IMoney AmountPlanned { get; set; }

        public IPaymentMethodInfo PaymentMethodInfo { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IMyTransactionDraft Transaction { get; set; }
    }
}
