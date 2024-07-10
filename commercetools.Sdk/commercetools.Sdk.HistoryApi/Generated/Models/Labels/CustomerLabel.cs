using commercetools.Sdk.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{

    public partial class CustomerLabel : ICustomerLabel
    {
        public string Type { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CustomerNumber { get; set; }
        public CustomerLabel()
        {
            this.Type = "CustomerLabel";
        }
    }
}
