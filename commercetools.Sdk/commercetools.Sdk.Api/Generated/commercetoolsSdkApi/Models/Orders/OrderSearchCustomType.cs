using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    public enum OrderSearchCustomType
    {
        [Description("BooleanType")]
        BooleanType,

        [Description("StringType")]
        StringType,

        [Description("LocalizedStringType")]
        LocalizedStringType,

        [Description("EnumType")]
        EnumType,

        [Description("LocalizedEnumType")]
        LocalizedEnumType,

        [Description("NumberType")]
        NumberType,

        [Description("DateType")]
        DateType,

        [Description("TimeType")]
        TimeType,

        [Description("DateTimeType")]
        DateTimeType,

        [Description("SetType.StringType")]
        SetTypeStringType,

        [Description("SetType.LocalizedStringType")]
        SetTypeLocalizedStringType,

        [Description("SetType.EnumType")]
        SetTypeEnumType,

        [Description("SetType.LocalizedEnumType")]
        SetTypeLocalizedEnumType,

        [Description("SetType.NumberType")]
        SetTypeNumberType,

        [Description("SetType.DateType")]
        SetTypeDateType,

        [Description("SetType.TimeType")]
        SetTypeTimeType,

        [Description("SetType.DateTimeType")]
        SetTypeDateTimeType
    }

    public class OrderSearchCustomTypeWrapper : IOrderSearchCustomType
    {
        public string JsonName { get; internal set; }
        public OrderSearchCustomType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IOrderSearchCustomType), "FindEnum")]
    public interface IOrderSearchCustomType : IJsonName, IEnumerable<char>
    {
        public static IOrderSearchCustomType BooleanType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.BooleanType, JsonName = "BooleanType" };

        public static IOrderSearchCustomType StringType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.StringType, JsonName = "StringType" };

        public static IOrderSearchCustomType LocalizedStringType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.LocalizedStringType, JsonName = "LocalizedStringType" };

        public static IOrderSearchCustomType EnumType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.EnumType, JsonName = "EnumType" };

        public static IOrderSearchCustomType LocalizedEnumType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.LocalizedEnumType, JsonName = "LocalizedEnumType" };

        public static IOrderSearchCustomType NumberType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.NumberType, JsonName = "NumberType" };

        public static IOrderSearchCustomType DateType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.DateType, JsonName = "DateType" };

        public static IOrderSearchCustomType TimeType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.TimeType, JsonName = "TimeType" };

        public static IOrderSearchCustomType DateTimeType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.DateTimeType, JsonName = "DateTimeType" };

        public static IOrderSearchCustomType SetTypeStringType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.SetTypeStringType, JsonName = "SetType.StringType" };

        public static IOrderSearchCustomType SetTypeLocalizedStringType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.SetTypeLocalizedStringType, JsonName = "SetType.LocalizedStringType" };

        public static IOrderSearchCustomType SetTypeEnumType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.SetTypeEnumType, JsonName = "SetType.EnumType" };

        public static IOrderSearchCustomType SetTypeLocalizedEnumType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.SetTypeLocalizedEnumType, JsonName = "SetType.LocalizedEnumType" };

        public static IOrderSearchCustomType SetTypeNumberType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.SetTypeNumberType, JsonName = "SetType.NumberType" };

        public static IOrderSearchCustomType SetTypeDateType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.SetTypeDateType, JsonName = "SetType.DateType" };

        public static IOrderSearchCustomType SetTypeTimeType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.SetTypeTimeType, JsonName = "SetType.TimeType" };

        public static IOrderSearchCustomType SetTypeDateTimeType = new OrderSearchCustomTypeWrapper
        { Value = OrderSearchCustomType.SetTypeDateTimeType, JsonName = "SetType.DateTimeType" };

        OrderSearchCustomType? Value { get; }

        static IOrderSearchCustomType[] Values()
        {
            return new[]
            {
                 BooleanType ,
                 StringType ,
                 LocalizedStringType ,
                 EnumType ,
                 LocalizedEnumType ,
                 NumberType ,
                 DateType ,
                 TimeType ,
                 DateTimeType ,
                 SetTypeStringType ,
                 SetTypeLocalizedStringType ,
                 SetTypeEnumType ,
                 SetTypeLocalizedEnumType ,
                 SetTypeNumberType ,
                 SetTypeDateType ,
                 SetTypeTimeType ,
                 SetTypeDateTimeType
             };
        }
        static IOrderSearchCustomType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new OrderSearchCustomTypeWrapper() { JsonName = value };
        }
    }
}
