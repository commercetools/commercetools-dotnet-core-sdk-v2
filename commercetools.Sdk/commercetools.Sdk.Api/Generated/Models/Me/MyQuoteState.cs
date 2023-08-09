using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    public enum MyQuoteState
    {
        [Description("Declined")]
        Declined,

        [Description("Accepted")]
        Accepted
    }

    public class MyQuoteStateWrapper : IMyQuoteState
    {
        public string JsonName { get; internal set; }
        public MyQuoteState? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IMyQuoteState), "FindEnum")]
    public interface IMyQuoteState : IJsonName, IEnumerable<char>
    {
        public static IMyQuoteState Declined = new MyQuoteStateWrapper
        { Value = MyQuoteState.Declined, JsonName = "Declined" };

        public static IMyQuoteState Accepted = new MyQuoteStateWrapper
        { Value = MyQuoteState.Accepted, JsonName = "Accepted" };

        MyQuoteState? Value { get; }

        static IMyQuoteState[] Values()
        {
            return new[]
            {
                 Declined ,
                 Accepted
             };
        }
        static IMyQuoteState FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new MyQuoteStateWrapper() { JsonName = value };
        }
    }
}
