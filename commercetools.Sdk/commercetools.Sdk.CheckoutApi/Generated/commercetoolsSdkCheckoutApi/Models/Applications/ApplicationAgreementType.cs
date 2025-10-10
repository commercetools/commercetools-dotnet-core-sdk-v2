using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    public enum ApplicationAgreementType
    {
        [Description("Text")]
        Text,

        [Description("MandatoryCheckbox")]
        MandatoryCheckbox
    }

    public class ApplicationAgreementTypeWrapper : IApplicationAgreementType
    {
        public string JsonName { get; internal set; }
        public ApplicationAgreementType? Value { get; internal set; }
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

    [EnumInterfaceCreator(typeof(IApplicationAgreementType), "FindEnum")]
    public interface IApplicationAgreementType : IJsonName, IEnumerable<char>
    {
        public static IApplicationAgreementType Text = new ApplicationAgreementTypeWrapper
        { Value = ApplicationAgreementType.Text, JsonName = "Text" };

        public static IApplicationAgreementType MandatoryCheckbox = new ApplicationAgreementTypeWrapper
        { Value = ApplicationAgreementType.MandatoryCheckbox, JsonName = "MandatoryCheckbox" };

        ApplicationAgreementType? Value { get; }

        static IApplicationAgreementType[] Values()
        {
            return new[]
            {
                 Text ,
                 MandatoryCheckbox
             };
        }
        static IApplicationAgreementType FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ApplicationAgreementTypeWrapper() { JsonName = value };
        }
    }
}
