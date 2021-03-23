using System;
using System.Text.Json;
using commercetools.Base.Validation;

namespace commercetools.Sdk.Api.Serialization
{
    public static class JsonExtensions
    {
        public static bool IsMoneyElement(this JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Object)
            {
                var propExists = element.TryGetProperty("currencyCode", out _);
                return propExists;
            }

            return false;
        }
        public static bool IsReferenceElement(this JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Object)
            {
                var propExists = element.TryGetProperty("typeId", out _);
                return propExists;
            }

            return false;
        }
        public static bool IsLocalizedStringElement(this JsonElement element, ICultureValidator cultureValidator)
        {
            if (element.ValueKind == JsonValueKind.Object)
            {
                using var enumerator =element.EnumerateObject().GetEnumerator();
                if (enumerator.MoveNext())
                {
                    var nameProp = enumerator.Current;
                    return cultureValidator.IsCultureValid(nameProp.Name);
                }
            }

            return false;
        }
        public static JsonValueKind GetFirstArrayElementValueKind(this JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Array)
            {
                using var enumerator =element.EnumerateArray().GetEnumerator();
                if (enumerator.MoveNext())
                {
                    return enumerator.Current.ValueKind;
                }
            }

            return JsonValueKind.Null;
        }
        public static JsonElement GetFirstArrayElement(this JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Array)
            {
                using var enumerator =element.EnumerateArray().GetEnumerator();
                if (enumerator.MoveNext())
                {
                    return enumerator.Current;
                }
            }

            return element;
        }
    }
}