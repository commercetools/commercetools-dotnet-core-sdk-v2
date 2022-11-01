using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyQuoteUpdate : IMyQuoteUpdate
    {
        public long Version { get; set; }

        public List<IMyQuoteUpdateAction> Actions { get; set; }
    }
}
