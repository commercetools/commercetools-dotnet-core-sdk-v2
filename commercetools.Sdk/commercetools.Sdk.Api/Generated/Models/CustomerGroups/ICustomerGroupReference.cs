using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupReference))]
    public partial interface ICustomerGroupReference : IReference
    {
        ICustomerGroup Obj { get; set; }

        new string Id { get; set; }

    }
}
