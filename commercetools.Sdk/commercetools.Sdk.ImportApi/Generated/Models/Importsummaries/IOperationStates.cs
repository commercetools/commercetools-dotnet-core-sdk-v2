using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importsummaries
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importsummaries.OperationStates))]
    public partial interface IOperationStates
    {
        long Processing { get; set; }

        long ValidationFailed { get; set; }

        long Unresolved { get; set; }

        long WaitForMasterVariant { get; set; }

        long Imported { get; set; }

        long Rejected { get; set; }
    }
}
