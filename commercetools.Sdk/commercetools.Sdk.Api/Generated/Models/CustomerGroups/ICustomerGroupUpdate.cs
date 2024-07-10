using commercetools.Sdk.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupUpdate))]
    public partial interface ICustomerGroupUpdate
    {
        long Version { get; set; }

        IList<ICustomerGroupUpdateAction> Actions { get; set; }
        IEnumerable<ICustomerGroupUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
