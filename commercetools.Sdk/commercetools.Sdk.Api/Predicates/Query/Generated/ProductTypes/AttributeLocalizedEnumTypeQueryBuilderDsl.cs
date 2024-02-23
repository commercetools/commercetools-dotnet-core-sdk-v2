using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeLocalizedEnumTypeQueryBuilderDsl
    {
        public AttributeLocalizedEnumTypeQueryBuilderDsl()
        {
        }

        public static AttributeLocalizedEnumTypeQueryBuilderDsl Of()
        {
            return new AttributeLocalizedEnumTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeLocalizedEnumTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeLocalizedEnumTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeLocalizedEnumTypeQueryBuilderDsl>(p, AttributeLocalizedEnumTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeLocalizedEnumTypeQueryBuilderDsl> Values(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeLocalizedEnumTypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("values"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumValueQueryBuilderDsl.Of())),
                AttributeLocalizedEnumTypeQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AttributeLocalizedEnumTypeQueryBuilderDsl> Values()
        {
            return new CollectionPredicateBuilder<AttributeLocalizedEnumTypeQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("values")),
                    p => new CombinationQueryPredicate<AttributeLocalizedEnumTypeQueryBuilderDsl>(p, AttributeLocalizedEnumTypeQueryBuilderDsl.Of));
        }

    }
}
