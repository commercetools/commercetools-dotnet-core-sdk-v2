using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.Address))]
    public partial interface IAddress : IBaseAddress
    {
        ICustomFields Custom { get; set; }
    }
}
