using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitCustomTypeSetMessage))]
    public partial interface IBusinessUnitCustomTypeSetMessage : IMessage
    {
        ICustomFields CustomFields { get; set; }

        string OldTypeId { get; set; }

    }
}
