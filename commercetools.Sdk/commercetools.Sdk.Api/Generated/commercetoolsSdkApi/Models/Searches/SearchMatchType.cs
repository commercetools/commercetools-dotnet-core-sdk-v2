using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    public enum SearchMatchType
    {
        [Description("any")]
        Any,

        [Description("all")]
        All
    }

    public class SearchMatchTypeWrapper : ISearchMatchType
    {
        public string JsonName { get; internal set; }
        public SearchMatchType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ISearchMatchType), "FindEnum")]
    public interface ISearchMatchType : IJsonName, IEnumerable<char>
    {
        public static ISearchMatchType Any = new SearchMatchTypeWrapper
        { Value = SearchMatchType.Any, JsonName = "any" };

        public static ISearchMatchType All = new SearchMatchTypeWrapper
        { Value = SearchMatchType.All, JsonName = "all" };

        SearchMatchType? Value { get; }

        static ISearchMatchType[] Values()
        {
            return new[]
            {
                 Any ,
                 All
             };
        }
        static ISearchMatchType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new SearchMatchTypeWrapper() { JsonName = value };
        }
    }
}
