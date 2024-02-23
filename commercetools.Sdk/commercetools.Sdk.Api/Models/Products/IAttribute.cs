using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTypes;

namespace commercetools.Sdk.Api.Models.Products
{
    public partial interface IAttribute
    {
#nullable enable
        public PlainEnumAttribute? ToPlainEnumAttribute()
        {
            if (this is PlainEnumAttribute t) { return t; }

            return null;
        }

        public LocalizedEnumAttribute? ToLocalizedEnumAttribute()
        {
            if (this is LocalizedEnumAttribute t) { return t; }

            return null;
        }

        public LocalizedStringAttribute? ToLocalizedStringAttribute()
        {
            if (this is LocalizedStringAttribute t) { return t; }

            return null;
        }

        public StringAttribute? ToStringAttribute()
        {
            if (this is StringAttribute t) { return t; }

            return null;
        }

        public MoneyAttribute? ToMoneyAttribute()
        {
            if (this is MoneyAttribute t) { return t; }

            return null;
        }

        public BooleanAttribute? ToBooleanAttribute()
        {
            if (this is BooleanAttribute t) { return t; }

            return null;
        }

        public DecimalAttribute? ToDecimalAttribute()
        {
            switch (this)
            {
                case DecimalAttribute d:
                    return d;
                case LongAttribute l:
                    return (DecimalAttribute)l;
                default:
                    return null;
            }
        }

        public LongAttribute? ToLongAttribute()
        {
            switch (this)
            {
                case DecimalAttribute d:
                    return (LongAttribute)d;
                case LongAttribute l:
                    return l;
                default:
                    return null;
            }

            return null;
        }

        public ReferenceAttribute? ToReferenceAttribute()
        {
            if (this is ReferenceAttribute t) { return t; }

            return null;
        }

        public NestedAttribute? ToNestedAttribute()
        {
            if (this is NestedAttribute t) { return t; }

            return null;
        }

        public SetAttribute<string>? ToSetStringAttribute()
        {
            if (this is SetAttribute<string> t) { return t; }

            return null;
        }

        public SetAttribute<LocalizedString>? ToSetLocalizedStringAttribute()
        {
            if (this is SetAttribute<LocalizedString> t) { return t; }

            return null;
        }

        public SetAttribute<IAttributePlainEnumValue>? ToSetPlainEnumAttribute()
        {
            if (this is SetAttribute<IAttributePlainEnumValue> t) { return t; }

            return null;
        }

        public SetAttribute<IAttributeLocalizedEnumValue>? ToSetLocalizedEnumAttribute()
        {
            if (this is SetAttribute<IAttributeLocalizedEnumValue> t) { return t; }

            return null;
        }

        public SetAttribute<ITypedMoney>? ToSetMoneyAttribute()
        {
            if (this is SetAttribute<ITypedMoney> t) { return t; }

            return null;
        }

        public SetAttribute<bool>? ToSetBooleanAttribute()
        {
            if (this is SetAttribute<bool> t) { return t; }

            return null;
        }

        public SetAttribute<decimal>? ToSetDecimalAttribute()
        {
            switch (this)
            {
                case SetAttribute<decimal> l:
                    return l;
                case SetAttribute<long> d:
                    return new SetAttribute<decimal>()
                    {
                        Name = d.Name,
                        Value = d.GetValue().Select(Convert.ToDecimal).ToList()
                    };
                default:
                    return null;
            }
        }

        public SetAttribute<long>? ToSetLongAttribute()
        {
            switch (this)
            {
                case SetAttribute<long> l:
                    return l;
                case SetAttribute<decimal> d:
                    return new SetAttribute<long>()
                    {
                        Name = d.Name,
                        Value = d.GetValue().Select(Convert.ToInt64).ToList()
                    };
                default:
                    return null;
            }
        }

        public SetAttribute<IReference>? ToSetReferenceAttribute()
        {
            if (this is SetAttribute<IReference> t) { return t; }

            return null;
        }

        public SetAttribute<List<IAttribute>>? ToSetOfNestedAttribute()
        {
            if (this is SetAttribute<List<IAttribute>> t) { return t; }

            return null;
        }
#nullable disable
    }
}