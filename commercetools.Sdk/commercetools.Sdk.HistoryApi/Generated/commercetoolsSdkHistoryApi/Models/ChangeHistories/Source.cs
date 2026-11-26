using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    public enum Source
    {
        [Description("MerchantCenter")]
        MerchantCenter,

        [Description("ImpEx")]
        ImpEx,

        [Description("ApiClient")]
        ApiClient,

        [Description("Import")]
        Import,

        [Description("Export")]
        Export,

        [Description("IntakeAgent")]
        IntakeAgent,

        [Description("PromotionsAgent")]
        PromotionsAgent,

        [Description("ManagedCommerceMCP")]
        ManagedCommerceMcp,

        [Description("ProductEnrichmentAgent")]
        ProductEnrichmentAgent
    }

    public class SourceWrapper : ISource
    {
        public string JsonName { get; internal set; }
        public Source? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(ISource), "FindEnum")]
    public interface ISource : IJsonName, IEnumerable<char>
    {
        public static ISource MerchantCenter = new SourceWrapper
        { Value = Source.MerchantCenter, JsonName = "MerchantCenter" };

        public static ISource ImpEx = new SourceWrapper
        { Value = Source.ImpEx, JsonName = "ImpEx" };

        public static ISource ApiClient = new SourceWrapper
        { Value = Source.ApiClient, JsonName = "ApiClient" };

        public static ISource Import = new SourceWrapper
        { Value = Source.Import, JsonName = "Import" };

        public static ISource Export = new SourceWrapper
        { Value = Source.Export, JsonName = "Export" };

        public static ISource IntakeAgent = new SourceWrapper
        { Value = Source.IntakeAgent, JsonName = "IntakeAgent" };

        public static ISource PromotionsAgent = new SourceWrapper
        { Value = Source.PromotionsAgent, JsonName = "PromotionsAgent" };

        public static ISource ManagedCommerceMcp = new SourceWrapper
        { Value = Source.ManagedCommerceMcp, JsonName = "ManagedCommerceMCP" };

        public static ISource ProductEnrichmentAgent = new SourceWrapper
        { Value = Source.ProductEnrichmentAgent, JsonName = "ProductEnrichmentAgent" };

        Source? Value { get; }

        static ISource[] Values()
        {
            return new[]
            {
                 MerchantCenter ,
                 ImpEx ,
                 ApiClient ,
                 Import ,
                 Export ,
                 IntakeAgent ,
                 PromotionsAgent ,
                 ManagedCommerceMcp ,
                 ProductEnrichmentAgent
             };
        }
        static ISource FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new SourceWrapper() { JsonName = value };
        }
    }
}
