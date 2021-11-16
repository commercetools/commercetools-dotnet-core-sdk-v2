using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.AddressDraft))]
    public partial interface IAddressDraft : IBaseAddress
    {
        ICustomFieldsDraft Custom { get; set;}
    }
}
