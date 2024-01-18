using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    public enum ProductSearchAttributeType
    {
        [Description("boolean")]
        Boolean,

        [Description("text")]
        Text,

        [Description("ltext")]
        Ltext,

        [Description("enum")]
        Enum,

        [Description("lenum")]
        Lenum,

        [Description("number")]
        Number,

        [Description("money")]
        Money,

        [Description("date")]
        Date,

        [Description("datetime")]
        Datetime,

        [Description("time")]
        Time,

        [Description("reference")]
        Reference,

        [Description("set_boolean")]
        SetBoolean,

        [Description("set_text")]
        SetText,

        [Description("set_ltext")]
        SetLtext,

        [Description("set_enum")]
        SetEnum,

        [Description("set_lenum")]
        SetLenum,

        [Description("set_number")]
        SetNumber,

        [Description("set_money")]
        SetMoney,

        [Description("set_date")]
        SetDate,

        [Description("set_datetime")]
        SetDatetime,

        [Description("set_time")]
        SetTime,

        [Description("set_reference")]
        SetReference
    }

    public class ProductSearchAttributeTypeWrapper : IProductSearchAttributeType
    {
        public string JsonName { get; internal set; }
        public ProductSearchAttributeType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IProductSearchAttributeType), "FindEnum")]
    public interface IProductSearchAttributeType : IJsonName, IEnumerable<char>
    {
        public static IProductSearchAttributeType Boolean = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.Boolean, JsonName = "boolean" };

        public static IProductSearchAttributeType Text = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.Text, JsonName = "text" };

        public static IProductSearchAttributeType Ltext = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.Ltext, JsonName = "ltext" };

        public static IProductSearchAttributeType Enum = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.Enum, JsonName = "enum" };

        public static IProductSearchAttributeType Lenum = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.Lenum, JsonName = "lenum" };

        public static IProductSearchAttributeType Number = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.Number, JsonName = "number" };

        public static IProductSearchAttributeType Money = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.Money, JsonName = "money" };

        public static IProductSearchAttributeType Date = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.Date, JsonName = "date" };

        public static IProductSearchAttributeType Datetime = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.Datetime, JsonName = "datetime" };

        public static IProductSearchAttributeType Time = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.Time, JsonName = "time" };

        public static IProductSearchAttributeType Reference = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.Reference, JsonName = "reference" };

        public static IProductSearchAttributeType SetBoolean = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.SetBoolean, JsonName = "set_boolean" };

        public static IProductSearchAttributeType SetText = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.SetText, JsonName = "set_text" };

        public static IProductSearchAttributeType SetLtext = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.SetLtext, JsonName = "set_ltext" };

        public static IProductSearchAttributeType SetEnum = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.SetEnum, JsonName = "set_enum" };

        public static IProductSearchAttributeType SetLenum = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.SetLenum, JsonName = "set_lenum" };

        public static IProductSearchAttributeType SetNumber = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.SetNumber, JsonName = "set_number" };

        public static IProductSearchAttributeType SetMoney = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.SetMoney, JsonName = "set_money" };

        public static IProductSearchAttributeType SetDate = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.SetDate, JsonName = "set_date" };

        public static IProductSearchAttributeType SetDatetime = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.SetDatetime, JsonName = "set_datetime" };

        public static IProductSearchAttributeType SetTime = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.SetTime, JsonName = "set_time" };

        public static IProductSearchAttributeType SetReference = new ProductSearchAttributeTypeWrapper
        { Value = ProductSearchAttributeType.SetReference, JsonName = "set_reference" };

        ProductSearchAttributeType? Value { get; }

        static IProductSearchAttributeType[] Values()
        {
            return new[]
            {
                 Boolean ,
                 Text ,
                 Ltext ,
                 Enum ,
                 Lenum ,
                 Number ,
                 Money ,
                 Date ,
                 Datetime ,
                 Time ,
                 Reference ,
                 SetBoolean ,
                 SetText ,
                 SetLtext ,
                 SetEnum ,
                 SetLenum ,
                 SetNumber ,
                 SetMoney ,
                 SetDate ,
                 SetDatetime ,
                 SetTime ,
                 SetReference
             };
        }
        static IProductSearchAttributeType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ProductSearchAttributeTypeWrapper() { JsonName = value };
        }
    }
}
