using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomerGroups.CustomerGroupReference))]
    public partial interface ICustomerGroupReference : IReference
    {
        ICustomerGroup Obj { get; set; }

        new string Id { get; set; }
    }
}
