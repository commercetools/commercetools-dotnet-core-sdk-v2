using commercetools.Sdk.ImportApi.Models.Importcontainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importcontainers.ImportContainerPagedResponse))]
    public partial interface IImportContainerPagedResponse
    {
        int Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long Total { get; set; }

        IList<IImportContainer> Results { get; set; }
        IEnumerable<IImportContainer> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
