using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Reservation : IReservation
    {
        public int Quantity { get; set; }

        public IReference Owner { get; set; }

        public string CreatedAt { get; set; }

        public string CheckoutStartedAt { get; set; }
    }
}
