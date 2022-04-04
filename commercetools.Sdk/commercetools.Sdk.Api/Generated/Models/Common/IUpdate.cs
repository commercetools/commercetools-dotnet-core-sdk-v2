using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.Update))]
    public partial interface IUpdate
    {
        long Version { get; set; }

        List<IUpdateAction> Actions { get; set; }
    }
}
