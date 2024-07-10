using commercetools.Sdk.Api.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionTrigger))]
    public partial interface IExtensionTrigger
    {
        IExtensionResourceTypeId ResourceTypeId { get; set; }

        IList<IExtensionAction> Actions { get; set; }
        IEnumerable<IExtensionAction> ActionsEnumerable { set => Actions = value.ToList(); }


        string Condition { get; set; }

    }
}
