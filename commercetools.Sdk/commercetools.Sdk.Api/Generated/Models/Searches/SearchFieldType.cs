using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    public enum SearchFieldType
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

    public class SearchFieldTypeWrapper : ISearchFieldType
    {
        public string JsonName { get; internal set; }
        public SearchFieldType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ISearchFieldType), "FindEnum")]
    public interface ISearchFieldType : IJsonName, IEnumerable<char>
    {
        public static ISearchFieldType Boolean = new SearchFieldTypeWrapper
        { Value = SearchFieldType.Boolean, JsonName = "boolean" };

        public static ISearchFieldType Text = new SearchFieldTypeWrapper
        { Value = SearchFieldType.Text, JsonName = "text" };

        public static ISearchFieldType Ltext = new SearchFieldTypeWrapper
        { Value = SearchFieldType.Ltext, JsonName = "ltext" };

        public static ISearchFieldType Enum = new SearchFieldTypeWrapper
        { Value = SearchFieldType.Enum, JsonName = "enum" };

        public static ISearchFieldType Lenum = new SearchFieldTypeWrapper
        { Value = SearchFieldType.Lenum, JsonName = "lenum" };

        public static ISearchFieldType Number = new SearchFieldTypeWrapper
        { Value = SearchFieldType.Number, JsonName = "number" };

        public static ISearchFieldType Money = new SearchFieldTypeWrapper
        { Value = SearchFieldType.Money, JsonName = "money" };

        public static ISearchFieldType Date = new SearchFieldTypeWrapper
        { Value = SearchFieldType.Date, JsonName = "date" };

        public static ISearchFieldType Datetime = new SearchFieldTypeWrapper
        { Value = SearchFieldType.Datetime, JsonName = "datetime" };

        public static ISearchFieldType Time = new SearchFieldTypeWrapper
        { Value = SearchFieldType.Time, JsonName = "time" };

        public static ISearchFieldType Reference = new SearchFieldTypeWrapper
        { Value = SearchFieldType.Reference, JsonName = "reference" };

        public static ISearchFieldType SetBoolean = new SearchFieldTypeWrapper
        { Value = SearchFieldType.SetBoolean, JsonName = "set_boolean" };

        public static ISearchFieldType SetText = new SearchFieldTypeWrapper
        { Value = SearchFieldType.SetText, JsonName = "set_text" };

        public static ISearchFieldType SetLtext = new SearchFieldTypeWrapper
        { Value = SearchFieldType.SetLtext, JsonName = "set_ltext" };

        public static ISearchFieldType SetEnum = new SearchFieldTypeWrapper
        { Value = SearchFieldType.SetEnum, JsonName = "set_enum" };

        public static ISearchFieldType SetLenum = new SearchFieldTypeWrapper
        { Value = SearchFieldType.SetLenum, JsonName = "set_lenum" };

        public static ISearchFieldType SetNumber = new SearchFieldTypeWrapper
        { Value = SearchFieldType.SetNumber, JsonName = "set_number" };

        public static ISearchFieldType SetMoney = new SearchFieldTypeWrapper
        { Value = SearchFieldType.SetMoney, JsonName = "set_money" };

        public static ISearchFieldType SetDate = new SearchFieldTypeWrapper
        { Value = SearchFieldType.SetDate, JsonName = "set_date" };

        public static ISearchFieldType SetDatetime = new SearchFieldTypeWrapper
        { Value = SearchFieldType.SetDatetime, JsonName = "set_datetime" };

        public static ISearchFieldType SetTime = new SearchFieldTypeWrapper
        { Value = SearchFieldType.SetTime, JsonName = "set_time" };

        public static ISearchFieldType SetReference = new SearchFieldTypeWrapper
        { Value = SearchFieldType.SetReference, JsonName = "set_reference" };

        SearchFieldType? Value { get; }

        static ISearchFieldType[] Values()
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
        static ISearchFieldType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new SearchFieldTypeWrapper() { JsonName = value };
        }
    }
}
