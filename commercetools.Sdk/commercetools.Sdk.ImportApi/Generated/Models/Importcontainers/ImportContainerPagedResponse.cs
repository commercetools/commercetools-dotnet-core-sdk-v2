using commercetools.Sdk.ImportApi.Models.Importcontainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{

    public partial class ImportContainerPagedResponse : IImportContainerPagedResponse
    {
        public int Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long Total { get; set; }

        public IList<IImportContainer> Results { get; set; }
        public IEnumerable<IImportContainer> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
