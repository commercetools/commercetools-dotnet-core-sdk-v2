using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.OrderPatchImportRequest))]
    public partial interface IOrderPatchImportRequest : IImportRequest
    {
        IList<IOrderPatchImport> Patches { get; set; }
        IEnumerable<IOrderPatchImport> PatchesEnumerable { set => Patches = value.ToList(); }


    }
}
