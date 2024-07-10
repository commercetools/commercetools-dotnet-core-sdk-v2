using commercetools.Sdk.ImportApi.Models.Importsummaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importsummaries
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importsummaries.ImportSummary))]
    public partial interface IImportSummary
    {
        IOperationStates States { get; set; }

        long Total { get; set; }

    }
}
