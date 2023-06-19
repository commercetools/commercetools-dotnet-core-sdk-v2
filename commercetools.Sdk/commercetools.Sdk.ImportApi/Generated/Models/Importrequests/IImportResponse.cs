using commercetools.Sdk.ImportApi.Models.Importoperations;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.ImportResponse))]
    public partial interface IImportResponse
    {
        IList<IImportOperationStatus> OperationStatus { get; set; }
        IEnumerable<IImportOperationStatus> OperationStatusEnumerable { set => OperationStatus = value.ToList(); }


    }
}
