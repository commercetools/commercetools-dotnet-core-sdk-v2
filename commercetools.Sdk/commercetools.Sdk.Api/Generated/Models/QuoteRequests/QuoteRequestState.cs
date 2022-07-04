using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    public enum QuoteRequestState
    {
        [Description("Submitted")]
        Submitted,

        [Description("Accepted")]
        Accepted,

        [Description("Closed")]
        Closed,

        [Description("Rejected")]
        Rejected,

        [Description("Cancelled")]
        Cancelled
    }

    public class QuoteRequestStateWrapper : IQuoteRequestState
    {
        public string JsonName { get; internal set; }
        public QuoteRequestState? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<char> GetEnumerator()
        {
            return JsonName.GetEnumerator();
        }
    }

    [EnumInterfaceCreator(typeof(IQuoteRequestState), "FindEnum")]
    public interface IQuoteRequestState : IJsonName, IEnumerable<char>
    {
        public static IQuoteRequestState Submitted = new QuoteRequestStateWrapper
        { Value = QuoteRequestState.Submitted, JsonName = "Submitted" };

        public static IQuoteRequestState Accepted = new QuoteRequestStateWrapper
        { Value = QuoteRequestState.Accepted, JsonName = "Accepted" };

        public static IQuoteRequestState Closed = new QuoteRequestStateWrapper
        { Value = QuoteRequestState.Closed, JsonName = "Closed" };

        public static IQuoteRequestState Rejected = new QuoteRequestStateWrapper
        { Value = QuoteRequestState.Rejected, JsonName = "Rejected" };

        public static IQuoteRequestState Cancelled = new QuoteRequestStateWrapper
        { Value = QuoteRequestState.Cancelled, JsonName = "Cancelled" };

        QuoteRequestState? Value { get; }

        static IQuoteRequestState[] Values()
        {
            return new[]
            {
                 Submitted ,
                 Accepted ,
                 Closed ,
                 Rejected ,
                 Cancelled
             };
        }
        static IQuoteRequestState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new QuoteRequestStateWrapper() { JsonName = value };
        }
    }
}
