using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupChangeNameAction))]
    public partial interface ICustomerGroupChangeNameAction : ICustomerGroupUpdateAction
    {
        string Name { get; set; }

    }
}
