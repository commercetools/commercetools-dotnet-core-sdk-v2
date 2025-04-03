using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    public enum EventType
    {
        [Description("ImportContainerCreated")]
        ImportContainerCreated,

        [Description("ImportContainerDeleted")]
        ImportContainerDeleted,

        [Description("ImportOperationRejected")]
        ImportOperationRejected,

        [Description("ImportUnresolved")]
        ImportUnresolved,

        [Description("ImportValidationFailed")]
        ImportValidationFailed,

        [Description("ImportWaitForMasterVariant")]
        ImportWaitForMasterVariant
    }

    public class EventTypeWrapper : IEventType
    {
        public string JsonName { get; internal set; }
        public EventType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IEventType), "FindEnum")]
    public interface IEventType : IJsonName, IEnumerable<char>
    {
        public static IEventType ImportContainerCreated = new EventTypeWrapper
        { Value = EventType.ImportContainerCreated, JsonName = "ImportContainerCreated" };

        public static IEventType ImportContainerDeleted = new EventTypeWrapper
        { Value = EventType.ImportContainerDeleted, JsonName = "ImportContainerDeleted" };

        public static IEventType ImportOperationRejected = new EventTypeWrapper
        { Value = EventType.ImportOperationRejected, JsonName = "ImportOperationRejected" };

        public static IEventType ImportUnresolved = new EventTypeWrapper
        { Value = EventType.ImportUnresolved, JsonName = "ImportUnresolved" };

        public static IEventType ImportValidationFailed = new EventTypeWrapper
        { Value = EventType.ImportValidationFailed, JsonName = "ImportValidationFailed" };

        public static IEventType ImportWaitForMasterVariant = new EventTypeWrapper
        { Value = EventType.ImportWaitForMasterVariant, JsonName = "ImportWaitForMasterVariant" };

        EventType? Value { get; }

        static IEventType[] Values()
        {
            return new[]
            {
                 ImportContainerCreated ,
                 ImportContainerDeleted ,
                 ImportOperationRejected ,
                 ImportUnresolved ,
                 ImportValidationFailed ,
                 ImportWaitForMasterVariant
             };
        }
        static IEventType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new EventTypeWrapper() { JsonName = value };
        }
    }
}
