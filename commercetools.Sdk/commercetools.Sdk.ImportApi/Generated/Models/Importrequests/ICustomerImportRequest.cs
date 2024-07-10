using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customers;
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
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.CustomerImportRequest))]
    public partial interface ICustomerImportRequest : IImportRequest
    {
        IList<ICustomerImport> Resources { get; set; }
        IEnumerable<ICustomerImport> ResourcesEnumerable { set => Resources = value.ToList(); }


    }
}
