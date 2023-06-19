using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Zones
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Zones.ZoneUpdateAction))]
    [SubTypeDiscriminator("addLocation", typeof(commercetools.Sdk.Api.Models.Zones.ZoneAddLocationAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.Zones.ZoneChangeNameAction))]
    [SubTypeDiscriminator("removeLocation", typeof(commercetools.Sdk.Api.Models.Zones.ZoneRemoveLocationAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.Zones.ZoneSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Zones.ZoneSetKeyAction))]
    public partial interface IZoneUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IZoneUpdateAction>
    {
        new string Action { get; set; }

        static commercetools.Sdk.Api.Models.Zones.ZoneAddLocationAction AddLocation(Action<commercetools.Sdk.Api.Models.Zones.ZoneAddLocationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Zones.ZoneAddLocationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Zones.ZoneChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.Zones.ZoneChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Zones.ZoneChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Zones.ZoneRemoveLocationAction RemoveLocation(Action<commercetools.Sdk.Api.Models.Zones.ZoneRemoveLocationAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Zones.ZoneRemoveLocationAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Zones.ZoneSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.Zones.ZoneSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Zones.ZoneSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Zones.ZoneSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.Zones.ZoneSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Zones.ZoneSetKeyAction();
            init?.Invoke(t);
            return t;
        }
    }
}
