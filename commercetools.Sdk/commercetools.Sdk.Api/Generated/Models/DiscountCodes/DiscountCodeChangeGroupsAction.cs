using commercetools.Sdk.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeChangeGroupsAction : IDiscountCodeChangeGroupsAction
    {
        public string Action { get; set; }

        public IList<string> Groups { get; set; }
        public IEnumerable<string> GroupsEnumerable { set => Groups = value.ToList(); }

        public DiscountCodeChangeGroupsAction()
        {
            this.Action = "changeGroups";
        }
    }
}
