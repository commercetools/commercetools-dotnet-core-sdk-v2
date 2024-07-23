using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    public enum AwsAuthenticationMode
    {
        [Description("Credentials")]
        Credentials,

        [Description("IAM")]
        Iam
    }

    public class AwsAuthenticationModeWrapper : IAwsAuthenticationMode
    {
        public string JsonName { get; internal set; }
        public AwsAuthenticationMode? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IAwsAuthenticationMode), "FindEnum")]
    public interface IAwsAuthenticationMode : IJsonName, IEnumerable<char>
    {
        public static IAwsAuthenticationMode Credentials = new AwsAuthenticationModeWrapper
        { Value = AwsAuthenticationMode.Credentials, JsonName = "Credentials" };

        public static IAwsAuthenticationMode Iam = new AwsAuthenticationModeWrapper
        { Value = AwsAuthenticationMode.Iam, JsonName = "IAM" };

        AwsAuthenticationMode? Value { get; }

        static IAwsAuthenticationMode[] Values()
        {
            return new[]
            {
                 Credentials ,
                 Iam
             };
        }
        static IAwsAuthenticationMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new AwsAuthenticationModeWrapper() { JsonName = value };
        }
    }
}
