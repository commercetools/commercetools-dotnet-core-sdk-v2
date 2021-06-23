using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Importrequests;
using commercetools.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importrequests.OrderPatchImportRequest))]
    public partial interface IOrderPatchImportRequest : IImportRequest
    {
        List<IOrderPatchImport> Patches { get; set;}
    }
}
