using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Customers
{
    public enum AuthenticationMode
    {
        [Description("Password")]
        Password,

        [Description("ExternalAuth")]
        ExternalAuth
    }

    public class AuthenticationModeWrapper : IAuthenticationMode
    {
        public string JsonName { get; internal set; }
        public AuthenticationMode? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(IAuthenticationMode), "FindEnum")]
    public interface IAuthenticationMode : IJsonName
    {
        public static IAuthenticationMode Password = new AuthenticationModeWrapper
        { Value = AuthenticationMode.Password, JsonName = "Password" };

        public static IAuthenticationMode ExternalAuth = new AuthenticationModeWrapper
        { Value = AuthenticationMode.ExternalAuth, JsonName = "ExternalAuth" };

        AuthenticationMode? Value { get; }

        static IAuthenticationMode[] Values()
        {
            return new[]
            {
                 Password ,
                 ExternalAuth
             };
        }
        static IAuthenticationMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AuthenticationModeWrapper() { JsonName = value };
        }
    }
}
