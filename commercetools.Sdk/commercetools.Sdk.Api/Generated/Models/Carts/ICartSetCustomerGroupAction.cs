using commercetools.Api.Models.CustomerGroups;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetCustomerGroupAction))]
    public partial interface ICartSetCustomerGroupAction : ICartUpdateAction
    {
        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }
    }
}
