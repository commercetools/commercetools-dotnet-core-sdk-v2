using commercetools.Sdk.ImportApi.Models.Importoperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{

    public partial class ImportResponse : IImportResponse
    {
        public IList<IImportOperationStatus> OperationStatus { get; set; }
        public IEnumerable<IImportOperationStatus> OperationStatusEnumerable { set => OperationStatus = value.ToList(); }

    }
}
