using commercetools.Sdk.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeGroupsAction))]
    public partial interface IDiscountCodeChangeGroupsAction : IDiscountCodeUpdateAction
    {
        IList<string> Groups { get; set; }
        IEnumerable<string> GroupsEnumerable { set => Groups = value.ToList(); }


    }
}
