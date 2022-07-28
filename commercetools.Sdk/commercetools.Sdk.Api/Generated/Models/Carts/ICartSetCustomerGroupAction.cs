using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomerGroupAction))]
    public partial interface ICartSetCustomerGroupAction : ICartUpdateAction
    {
        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

    }
}
