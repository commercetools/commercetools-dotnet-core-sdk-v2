using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Customers
{
    public enum AnonymousCartSignInMode
    {
        [Description("MergeWithExistingCustomerCart")]
        MergeWithExistingCustomerCart,

        [Description("UseAsNewActiveCustomerCart")]
        UseAsNewActiveCustomerCart
    }

    public class AnonymousCartSignInModeWrapper : IAnonymousCartSignInMode
    {
        public string JsonName { get; internal set; }
        public AnonymousCartSignInMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IAnonymousCartSignInMode), "FindEnum")]
    public interface IAnonymousCartSignInMode : IJsonName, IEnumerable<char>
    {
        public static IAnonymousCartSignInMode MergeWithExistingCustomerCart = new AnonymousCartSignInModeWrapper
        { Value = AnonymousCartSignInMode.MergeWithExistingCustomerCart, JsonName = "MergeWithExistingCustomerCart" };

        public static IAnonymousCartSignInMode UseAsNewActiveCustomerCart = new AnonymousCartSignInModeWrapper
        { Value = AnonymousCartSignInMode.UseAsNewActiveCustomerCart, JsonName = "UseAsNewActiveCustomerCart" };

        AnonymousCartSignInMode? Value { get; }

        static IAnonymousCartSignInMode[] Values()
        {
            return new[]
            {
                 MergeWithExistingCustomerCart ,
                 UseAsNewActiveCustomerCart
             };
        }
        static IAnonymousCartSignInMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AnonymousCartSignInModeWrapper() { JsonName = value };
        }
    }
}
