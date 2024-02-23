using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Quotes
{
    public enum QuoteState
    {
        [Description("Pending")]
        Pending,

        [Description("Declined")]
        Declined,

        [Description("DeclinedForRenegotiation")]
        DeclinedForRenegotiation,

        [Description("RenegotiationAddressed")]
        RenegotiationAddressed,

        [Description("Accepted")]
        Accepted,

        [Description("Withdrawn")]
        Withdrawn
    }

    public class QuoteStateWrapper : IQuoteState
    {
        public string JsonName { get; internal set; }
        public QuoteState? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IQuoteState), "FindEnum")]
    public interface IQuoteState : IJsonName, IEnumerable<char>
    {
        public static IQuoteState Pending = new QuoteStateWrapper
        { Value = QuoteState.Pending, JsonName = "Pending" };

        public static IQuoteState Declined = new QuoteStateWrapper
        { Value = QuoteState.Declined, JsonName = "Declined" };

        public static IQuoteState DeclinedForRenegotiation = new QuoteStateWrapper
        { Value = QuoteState.DeclinedForRenegotiation, JsonName = "DeclinedForRenegotiation" };

        public static IQuoteState RenegotiationAddressed = new QuoteStateWrapper
        { Value = QuoteState.RenegotiationAddressed, JsonName = "RenegotiationAddressed" };

        public static IQuoteState Accepted = new QuoteStateWrapper
        { Value = QuoteState.Accepted, JsonName = "Accepted" };

        public static IQuoteState Withdrawn = new QuoteStateWrapper
        { Value = QuoteState.Withdrawn, JsonName = "Withdrawn" };

        QuoteState? Value { get; }

        static IQuoteState[] Values()
        {
            return new[]
            {
                 Pending ,
                 Declined ,
                 DeclinedForRenegotiation ,
                 RenegotiationAddressed ,
                 Accepted ,
                 Withdrawn
             };
        }
        static IQuoteState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new QuoteStateWrapper() { JsonName = value };
        }
    }
}
