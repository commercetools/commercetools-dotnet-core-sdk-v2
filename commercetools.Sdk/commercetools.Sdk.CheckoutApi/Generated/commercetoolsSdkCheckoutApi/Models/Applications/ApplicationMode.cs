using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    public enum ApplicationMode
    {
        [Description("CompleteFlow")]
        CompleteFlow,

        [Description("PaymentOnly")]
        PaymentOnly
    }

    public class ApplicationModeWrapper : IApplicationMode
    {
        public string JsonName { get; internal set; }
        public ApplicationMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IApplicationMode), "FindEnum")]
    public interface IApplicationMode : IJsonName, IEnumerable<char>
    {
        public static IApplicationMode CompleteFlow = new ApplicationModeWrapper
        { Value = ApplicationMode.CompleteFlow, JsonName = "CompleteFlow" };

        public static IApplicationMode PaymentOnly = new ApplicationModeWrapper
        { Value = ApplicationMode.PaymentOnly, JsonName = "PaymentOnly" };

        ApplicationMode? Value { get; }

        static IApplicationMode[] Values()
        {
            return new[]
            {
                 CompleteFlow ,
                 PaymentOnly
             };
        }
        static IApplicationMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ApplicationModeWrapper() { JsonName = value };
        }
    }
}
