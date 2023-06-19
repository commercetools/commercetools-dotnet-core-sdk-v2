using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
