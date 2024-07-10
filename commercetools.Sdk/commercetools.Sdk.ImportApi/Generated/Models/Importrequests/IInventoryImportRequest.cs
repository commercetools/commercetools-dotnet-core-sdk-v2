using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using commercetools.Sdk.ImportApi.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.InventoryImportRequest))]
    public partial interface IInventoryImportRequest : IImportRequest
    {
        IList<IInventoryImport> Resources { get; set; }
        IEnumerable<IInventoryImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
