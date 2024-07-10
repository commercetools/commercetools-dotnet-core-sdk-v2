using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class FieldTypeQueryBuilderDsl
    {
        public FieldTypeQueryBuilderDsl()
        {
        }

        public static FieldTypeQueryBuilderDsl Of()
        {
            return new FieldTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<FieldTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<FieldTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<FieldTypeQueryBuilderDsl>(p, FieldTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<FieldTypeQueryBuilderDsl> AsBoolean(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldBooleanTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldBooleanTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldBooleanTypeQueryBuilderDsl.Of()),
                FieldTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<FieldTypeQueryBuilderDsl> AsDateTime(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldDateTimeTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldDateTimeTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldDateTimeTypeQueryBuilderDsl.Of()),
                FieldTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<FieldTypeQueryBuilderDsl> AsDate(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldDateTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldDateTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldDateTypeQueryBuilderDsl.Of()),
                FieldTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<FieldTypeQueryBuilderDsl> AsEnum(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldEnumTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldEnumTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldEnumTypeQueryBuilderDsl.Of()),
                FieldTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<FieldTypeQueryBuilderDsl> AsLocalizedEnum(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedEnumTypeQueryBuilderDsl.Of()),
                FieldTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<FieldTypeQueryBuilderDsl> AsLocalizedString(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedStringTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedStringTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldLocalizedStringTypeQueryBuilderDsl.Of()),
                FieldTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<FieldTypeQueryBuilderDsl> AsMoney(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldMoneyTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldMoneyTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldMoneyTypeQueryBuilderDsl.Of()),
                FieldTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<FieldTypeQueryBuilderDsl> AsNumber(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldNumberTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldNumberTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldNumberTypeQueryBuilderDsl.Of()),
                FieldTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<FieldTypeQueryBuilderDsl> AsReference(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldReferenceTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldReferenceTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldReferenceTypeQueryBuilderDsl.Of()),
                FieldTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<FieldTypeQueryBuilderDsl> AsSet(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldSetTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldSetTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldSetTypeQueryBuilderDsl.Of()),
                FieldTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<FieldTypeQueryBuilderDsl> AsString(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldStringTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldStringTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldStringTypeQueryBuilderDsl.Of()),
                FieldTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<FieldTypeQueryBuilderDsl> AsTime(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldTimeTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldTimeTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<FieldTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldTimeTypeQueryBuilderDsl.Of()),
                FieldTypeQueryBuilderDsl.Of);
        }
    }
}
