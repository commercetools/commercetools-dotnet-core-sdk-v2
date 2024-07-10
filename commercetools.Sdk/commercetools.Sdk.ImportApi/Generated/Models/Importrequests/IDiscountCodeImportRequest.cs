using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.DiscountCodes;
using commercetools.Sdk.ImportApi.Models.Importrequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.DiscountCodeImportRequest))]
    public partial interface IDiscountCodeImportRequest : IImportRequest
    {
        IList<IDiscountCodeImport> Resources { get; set; }
        IEnumerable<IDiscountCodeImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
