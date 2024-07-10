using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyOrderFromCartDraft : IMyOrderFromCartDraft
    {
        public string Id { get; set; }

        public long Version { get; set; }
    }
}
