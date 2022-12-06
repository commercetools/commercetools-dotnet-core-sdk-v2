using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeGroupsAction))]
    public partial interface IDiscountCodeChangeGroupsAction : IDiscountCodeUpdateAction
    {
        IList<string> Groups { get; set; }
        IEnumerable<string> GroupsEnumerable { set => Groups = value.ToList(); }


    }
}
