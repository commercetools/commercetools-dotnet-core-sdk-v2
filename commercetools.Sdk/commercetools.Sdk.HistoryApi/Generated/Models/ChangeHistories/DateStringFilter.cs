using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    public enum DateStringFilter
    {
        [Description("now")]
        Now
    }

    public class DateStringFilterWrapper : IDateStringFilter
    {
        public string JsonName { get; internal set; }
        public DateStringFilter? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IDateStringFilter), "FindEnum")]
    public interface IDateStringFilter : IJsonName, IEnumerable<char>
    {
        public static IDateStringFilter Now = new DateStringFilterWrapper
        { Value = DateStringFilter.Now, JsonName = "now" };

        DateStringFilter? Value { get; }

        static IDateStringFilter[] Values()
        {
            return new[]
            {
                 Now
             };
        }
        static IDateStringFilter FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new DateStringFilterWrapper() { JsonName = value };
        }
    }
}
