using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditUpdate))]
    public partial interface IOrderEditUpdate
    {
        long Version { get; set; }

        List<IOrderEditUpdateAction> Actions { get; set; }

        bool? DryRun { get; set; }

    }
}
