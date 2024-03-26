using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    public enum SearchSortMode
    {
        [Description("min")]
        Min,

        [Description("max")]
        Max,

        [Description("avg")]
        Avg,

        [Description("sum")]
        Sum
    }

    public class SearchSortModeWrapper : ISearchSortMode
    {
        public string JsonName { get; internal set; }
        public SearchSortMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ISearchSortMode), "FindEnum")]
    public interface ISearchSortMode : IJsonName, IEnumerable<char>
    {
        public static ISearchSortMode Min = new SearchSortModeWrapper
        { Value = SearchSortMode.Min, JsonName = "min" };

        public static ISearchSortMode Max = new SearchSortModeWrapper
        { Value = SearchSortMode.Max, JsonName = "max" };

        public static ISearchSortMode Avg = new SearchSortModeWrapper
        { Value = SearchSortMode.Avg, JsonName = "avg" };

        public static ISearchSortMode Sum = new SearchSortModeWrapper
        { Value = SearchSortMode.Sum, JsonName = "sum" };

        SearchSortMode? Value { get; }

        static ISearchSortMode[] Values()
        {
            return new[]
            {
                 Min ,
                 Max ,
                 Avg ,
                 Sum
             };
        }
        static ISearchSortMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new SearchSortModeWrapper() { JsonName = value };
        }
    }
}
