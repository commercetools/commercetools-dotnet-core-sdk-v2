using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeTypeQueryBuilderDsl
    {
        public AttributeTypeQueryBuilderDsl()
        {
        }

        public static AttributeTypeQueryBuilderDsl Of()
        {
            return new AttributeTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(p, AttributeTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<AttributeTypeQueryBuilderDsl> AsBoolean(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeBooleanTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeBooleanTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeBooleanTypeQueryBuilderDsl.Of()),
                AttributeTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeTypeQueryBuilderDsl> AsDatetime(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeDateTimeTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeDateTimeTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeDateTimeTypeQueryBuilderDsl.Of()),
                AttributeTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeTypeQueryBuilderDsl> AsDate(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeDateTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeDateTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeDateTypeQueryBuilderDsl.Of()),
                AttributeTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeTypeQueryBuilderDsl> AsEnum(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeEnumTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeEnumTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeEnumTypeQueryBuilderDsl.Of()),
                AttributeTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeTypeQueryBuilderDsl> AsLtext(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizableTextTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizableTextTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizableTextTypeQueryBuilderDsl.Of()),
                AttributeTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeTypeQueryBuilderDsl> AsLenum(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumTypeQueryBuilderDsl.Of()),
                AttributeTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeTypeQueryBuilderDsl> AsMoney(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeMoneyTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeMoneyTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeMoneyTypeQueryBuilderDsl.Of()),
                AttributeTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeTypeQueryBuilderDsl> AsNested(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeNestedTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeNestedTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeNestedTypeQueryBuilderDsl.Of()),
                AttributeTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeTypeQueryBuilderDsl> AsNumber(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeNumberTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeNumberTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeNumberTypeQueryBuilderDsl.Of()),
                AttributeTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeTypeQueryBuilderDsl> AsReference(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeReferenceTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeReferenceTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeReferenceTypeQueryBuilderDsl.Of()),
                AttributeTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeTypeQueryBuilderDsl> AsSet(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeSetTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeSetTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeSetTypeQueryBuilderDsl.Of()),
                AttributeTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeTypeQueryBuilderDsl> AsText(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTextTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTextTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTextTypeQueryBuilderDsl.Of()),
                AttributeTypeQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<AttributeTypeQueryBuilderDsl> AsTime(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTimeTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTimeTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeTypeQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeTimeTypeQueryBuilderDsl.Of()),
                AttributeTypeQueryBuilderDsl.Of);
        }
    }
}
