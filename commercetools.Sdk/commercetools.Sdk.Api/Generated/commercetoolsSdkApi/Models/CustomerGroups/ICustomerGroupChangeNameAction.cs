using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupChangeNameAction))]
    public partial interface ICustomerGroupChangeNameAction : ICustomerGroupUpdateAction
    {
        string Name { get; set; }

    }
}
