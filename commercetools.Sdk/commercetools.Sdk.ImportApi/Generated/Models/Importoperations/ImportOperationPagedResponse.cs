using commercetools.Sdk.ImportApi.Models.Importoperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importoperations
{

    public partial class ImportOperationPagedResponse : IImportOperationPagedResponse
    {
        public int Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long Total { get; set; }

        public IList<IImportOperation> Results { get; set; }
        public IEnumerable<IImportOperation> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
