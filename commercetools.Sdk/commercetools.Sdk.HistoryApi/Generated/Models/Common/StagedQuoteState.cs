using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public enum StagedQuoteState
    {
        [Description("InProgress")]
        InProgress,

        [Description("Sent")]
        Sent,

        [Description("Closed")]
        Closed
    }

    public class StagedQuoteStateWrapper : IStagedQuoteState
    {
        public string JsonName { get; internal set; }
        public StagedQuoteState? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IStagedQuoteState), "FindEnum")]
    public interface IStagedQuoteState : IJsonName, IEnumerable<char>
    {
        public static IStagedQuoteState InProgress = new StagedQuoteStateWrapper
        { Value = StagedQuoteState.InProgress, JsonName = "InProgress" };

        public static IStagedQuoteState Sent = new StagedQuoteStateWrapper
        { Value = StagedQuoteState.Sent, JsonName = "Sent" };

        public static IStagedQuoteState Closed = new StagedQuoteStateWrapper
        { Value = StagedQuoteState.Closed, JsonName = "Closed" };

        StagedQuoteState? Value { get; }

        static IStagedQuoteState[] Values()
        {
            return new[]
            {
                 InProgress ,
                 Sent ,
                 Closed
             };
        }
        static IStagedQuoteState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new StagedQuoteStateWrapper() { JsonName = value };
        }
    }
}
