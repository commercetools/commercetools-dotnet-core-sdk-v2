using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyQuoteUpdate))]
    public partial interface IMyQuoteUpdate
    {
        long Version { get; set; }

        List<IMyQuoteUpdateAction> Actions { get; set; }

    }
}
