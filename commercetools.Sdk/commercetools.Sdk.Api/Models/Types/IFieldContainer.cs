using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Serialization;

namespace commercetools.Sdk.Api.Models.Types;

public partial interface IFieldContainer
{
    public object GetValue(string fieldName)
    {
        TryGetValue(fieldName, out object value);

        return value;
    }
#nullable enable
    CustomFieldEnumValue? AsPlainEnum(string fieldName)
    {
        if (GetValue(fieldName) is CustomFieldEnumValue value) { return value; }

        return null;
    }

    public CustomFieldLocalizedEnumValue? AsLocalizedEnum(string fieldName)
    {
        if (GetValue(fieldName) is CustomFieldLocalizedEnumValue value) { return value; }

        return null;
    }

    public LocalizedString? AsLocalizedString(string fieldName)
    {
        if (GetValue(fieldName) is LocalizedString value) { return value; }

        return null;
    }

    public string? AsString(string fieldName)
    {
        if (GetValue(fieldName) is string value) { return value; }

        return null;
    }

    public ITypedMoney? AsMoney(string fieldName)
    {
        if (GetValue(fieldName) is ITypedMoney value) { return value; }

        return null;
    }

    public bool? AsBoolean(string fieldName)
    {
        if (GetValue(fieldName) is bool value) { return value; }

        return null;
    }

    public decimal? AsDecimal(string fieldName)
    {
        var value = GetValue(fieldName);
        if (value is decimal decimalValue) { return decimalValue; }
        if (value is long longValue) { return Convert.ToDecimal(longValue); }
        if (value is JsonElement { ValueKind: JsonValueKind.Number } element)
        {
            return element.GetDecimal();
        }
            
        return null;
    }

    public long? AsLong(string fieldName)
    {
        var value = GetValue(fieldName);
        if (value is decimal decimalValue) { return Convert.ToInt64(decimalValue); }
        if (value is long longValue) { return longValue; }
        if (value is JsonElement { ValueKind: JsonValueKind.Number } element)
        {
            return Convert.ToInt64(element.GetDecimal());
        }

        return null;
    }

    public IReference? AsReference(string fieldName)
    {
        if (GetValue(fieldName) is IReference value) { return value; }

        return null;
    }

    public IList<string>? AsSetString(string fieldName)
    {
        if (GetValue(fieldName) is IList<string> value) { return value; }

        return null;
    }

    public IList<LocalizedString>? AsSetLocalizedString(string fieldName)
    {
        if (GetValue(fieldName) is IList<LocalizedString> value) { return value; }

        return null;
    }

    public IList<ICustomFieldEnumValue>? AsSetPlainEnum(string fieldName)
    {
        if (GetValue(fieldName) is IList<ICustomFieldEnumValue> value) { return value; }

        return null;
    }

    public IList<ICustomFieldLocalizedEnumValue>? AsSetLocalizedEnum(string fieldName)
    {
        if (GetValue(fieldName) is IList<ICustomFieldLocalizedEnumValue> value) { return value; }

        return null;
    }

    public IList<ITypedMoney>? AsSetMoney(string fieldName)
    {
        if (GetValue(fieldName) is IList<ITypedMoney> value) { return value; }

        return null;
    }

    public IList<bool>? AsSetBoolean(string fieldName)
    {
        if (GetValue(fieldName) is IList<bool> value) { return value; }

        return null;
    }

    public IList<decimal>? AsSetDecimal(string fieldName)
    {
        var value = GetValue(fieldName);

        if (value is IList<decimal> decimals) { return decimals; }
        if (value is IList<long> longs)
        {
            return longs.Select(Convert.ToDecimal).ToList();
        }
        if (value is JsonElement { ValueKind: JsonValueKind.Array } elements && elements.GetFirstArrayElementValueKind() == JsonValueKind.Number)
        {
            return elements.EnumerateArray().Select(element => element.GetDecimal()).ToList();
        }

        return null;
    }

    public IList<long>? AsSetLong(string fieldName)
    {
        var value = GetValue(fieldName);
        if (value is IList<long> longs) { return longs; }
        if (value is IList<decimal> decimals)
        {
            return decimals.Select(Convert.ToInt64).ToList();
        }
        if (value is JsonElement { ValueKind: JsonValueKind.Array } elements && elements.GetFirstArrayElementValueKind() == JsonValueKind.Number)
        {
            return elements.EnumerateArray().Select(element => Convert.ToInt64(element.GetDecimal())).ToList();
        }

        return null;
    }

    public IList<IReference>? AsSetReference(string fieldName)
    {
        if (GetValue(fieldName) is IList<IReference> value) { return value; }

        return null;
    }
#nullable disable
}