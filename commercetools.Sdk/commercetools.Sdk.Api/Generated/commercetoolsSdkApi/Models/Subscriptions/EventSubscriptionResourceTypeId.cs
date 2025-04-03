using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    public enum EventSubscriptionResourceTypeId
    {
        [Description("import-api")]
        ImportApi
    }

    public class EventSubscriptionResourceTypeIdWrapper : IEventSubscriptionResourceTypeId
    {
        public string JsonName { get; internal set; }
        public EventSubscriptionResourceTypeId? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public new IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IEventSubscriptionResourceTypeId), "FindEnum")]
    public interface IEventSubscriptionResourceTypeId : IJsonName, IEnumerable<char>
    {
        public static IEventSubscriptionResourceTypeId ImportApi = new EventSubscriptionResourceTypeIdWrapper
        { Value = EventSubscriptionResourceTypeId.ImportApi, JsonName = "import-api" };

        EventSubscriptionResourceTypeId? Value { get; }

        static IEventSubscriptionResourceTypeId[] Values()
        {
            return new[]
            {
                 ImportApi
             };
        }
        static IEventSubscriptionResourceTypeId FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new EventSubscriptionResourceTypeIdWrapper() { JsonName = value };
        }
    }
}
