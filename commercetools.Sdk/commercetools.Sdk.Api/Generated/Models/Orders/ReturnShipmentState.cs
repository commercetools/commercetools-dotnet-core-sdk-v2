using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    public enum ReturnShipmentState
    {
        [Description("Advised")]
        Advised,

        [Description("Returned")]
        Returned,

        [Description("BackInStock")]
        BackInStock,

        [Description("Unusable")]
        Unusable
    }

    public class ReturnShipmentStateWrapper : IReturnShipmentState
    {
        public string JsonName { get; internal set; }
        public ReturnShipmentState? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IReturnShipmentState), "FindEnum")]
    public interface IReturnShipmentState : IJsonName, IEnumerable<char>
    {
        public static IReturnShipmentState Advised = new ReturnShipmentStateWrapper
        { Value = ReturnShipmentState.Advised, JsonName = "Advised" };

        public static IReturnShipmentState Returned = new ReturnShipmentStateWrapper
        { Value = ReturnShipmentState.Returned, JsonName = "Returned" };

        public static IReturnShipmentState BackInStock = new ReturnShipmentStateWrapper
        { Value = ReturnShipmentState.BackInStock, JsonName = "BackInStock" };

        public static IReturnShipmentState Unusable = new ReturnShipmentStateWrapper
        { Value = ReturnShipmentState.Unusable, JsonName = "Unusable" };

        ReturnShipmentState? Value { get; }

        static IReturnShipmentState[] Values()
        {
            return new[]
            {
                 Advised ,
                 Returned ,
                 BackInStock ,
                 Unusable
             };
        }
        static IReturnShipmentState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ReturnShipmentStateWrapper() { JsonName = value };
        }
    }
}
