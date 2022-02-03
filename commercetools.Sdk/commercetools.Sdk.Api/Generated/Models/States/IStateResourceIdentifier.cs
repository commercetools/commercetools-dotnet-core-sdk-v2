using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DeserializeAs(typeof(commercetools.Api.Models.States.StateResourceIdentifier))]
    public partial interface IStateResourceIdentifier : IResourceIdentifier
    {
        new string Id { get; set; }

        new string Key { get; set; }
    }
}
