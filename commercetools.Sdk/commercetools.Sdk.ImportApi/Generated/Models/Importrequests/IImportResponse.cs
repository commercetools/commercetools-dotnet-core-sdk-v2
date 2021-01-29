using commercetools.ImportApi.Models.Importoperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importrequests.ImportResponse))]
    public partial interface IImportResponse 
    {
        List<IImportOperationStatus> OperationStatus { get; set;}
    }
}
