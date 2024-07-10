using commercetools.Sdk.ImportApi.Models.Importsummaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importsummaries
{

    public partial class ImportSummary : IImportSummary
    {
        public IOperationStates States { get; set; }

        public long Total { get; set; }
    }
}
