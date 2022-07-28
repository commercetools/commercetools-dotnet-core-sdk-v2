using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyQuoteRequestUpdate))]
    public partial interface IMyQuoteRequestUpdate
    {
        long Version { get; set; }

        List<IMyQuoteRequestUpdateAction> Actions { get; set; }

    }
}
