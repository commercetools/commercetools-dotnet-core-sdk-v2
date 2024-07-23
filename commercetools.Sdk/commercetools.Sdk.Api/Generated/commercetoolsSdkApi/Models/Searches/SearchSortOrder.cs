using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    public enum SearchSortOrder
    {
        [Description("asc")]
        Asc,

        [Description("desc")]
        Desc
    }

    public class SearchSortOrderWrapper : ISearchSortOrder
    {
        public string JsonName { get; internal set; }
        public SearchSortOrder? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ISearchSortOrder), "FindEnum")]
    public interface ISearchSortOrder : IJsonName, IEnumerable<char>
    {
        public static ISearchSortOrder Asc = new SearchSortOrderWrapper
        { Value = SearchSortOrder.Asc, JsonName = "asc" };

        public static ISearchSortOrder Desc = new SearchSortOrderWrapper
        { Value = SearchSortOrder.Desc, JsonName = "desc" };

        SearchSortOrder? Value { get; }

        static ISearchSortOrder[] Values()
        {
            return new[]
            {
                 Asc ,
                 Desc
             };
        }
        static ISearchSortOrder FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new SearchSortOrderWrapper() { JsonName = value };
        }
    }
}
