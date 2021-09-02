using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.Projects
{
    public enum SearchIndexingConfigurationStatus
    {
        [Description("Activated")]
        Activated,

        [Description("Deactivated")]
        Deactivated,

        [Description("Indexing")]
        Indexing
    }

    public class SearchIndexingConfigurationStatusWrapper : ISearchIndexingConfigurationStatus
    {
        public string JsonName { get; internal set; }
        public SearchIndexingConfigurationStatus? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(ISearchIndexingConfigurationStatus), "FindEnum")]
    public interface ISearchIndexingConfigurationStatus : IJsonName
    {
        public static ISearchIndexingConfigurationStatus Activated = new SearchIndexingConfigurationStatusWrapper
        { Value = SearchIndexingConfigurationStatus.Activated, JsonName = "Activated" };

        public static ISearchIndexingConfigurationStatus Deactivated = new SearchIndexingConfigurationStatusWrapper
        { Value = SearchIndexingConfigurationStatus.Deactivated, JsonName = "Deactivated" };

        public static ISearchIndexingConfigurationStatus Indexing = new SearchIndexingConfigurationStatusWrapper
        { Value = SearchIndexingConfigurationStatus.Indexing, JsonName = "Indexing" };

        SearchIndexingConfigurationStatus? Value { get; }

        static ISearchIndexingConfigurationStatus[] Values()
        {
            return new[]
            {
                 Activated ,
                 Deactivated ,
                 Indexing
             };
        }
        static ISearchIndexingConfigurationStatus FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new SearchIndexingConfigurationStatusWrapper() { JsonName = value };
        }
    }
}
