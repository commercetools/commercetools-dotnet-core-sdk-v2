using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Projects
{
    public enum OrderSearchStatus
    {
        [Description("Activated")]
        Activated,

        [Description("Deactivated")]
        Deactivated
    }

    public class OrderSearchStatusWrapper : IOrderSearchStatus
    {
        public string JsonName { get; internal set; }
        public OrderSearchStatus? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IOrderSearchStatus), "FindEnum")]
    public interface IOrderSearchStatus : IJsonName, IEnumerable<char>
    {
        public static IOrderSearchStatus Activated = new OrderSearchStatusWrapper
        { Value = OrderSearchStatus.Activated, JsonName = "Activated" };

        public static IOrderSearchStatus Deactivated = new OrderSearchStatusWrapper
        { Value = OrderSearchStatus.Deactivated, JsonName = "Deactivated" };

        OrderSearchStatus? Value { get; }

        static IOrderSearchStatus[] Values()
        {
            return new[]
            {
                 Activated ,
                 Deactivated
             };
        }
        static IOrderSearchStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new OrderSearchStatusWrapper() { JsonName = value };
        }
    }
}
