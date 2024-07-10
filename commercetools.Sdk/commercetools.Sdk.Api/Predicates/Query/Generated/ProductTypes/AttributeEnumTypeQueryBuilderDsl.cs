using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeEnumTypeQueryBuilderDsl
    {
        public AttributeEnumTypeQueryBuilderDsl()
        {
        }

        public static AttributeEnumTypeQueryBuilderDsl Of()
        {
            return new AttributeEnumTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeEnumTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeEnumTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeEnumTypeQueryBuilderDsl>(p, AttributeEnumTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeEnumTypeQueryBuilderDsl> Values(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributePlainEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributePlainEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeEnumTypeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("values"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributePlainEnumValueQueryBuilderDsl.Of())),
                AttributeEnumTypeQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AttributeEnumTypeQueryBuilderDsl> Values()
        {
            return new CollectionPredicateBuilder<AttributeEnumTypeQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("values")),
                    p => new CombinationQueryPredicate<AttributeEnumTypeQueryBuilderDsl>(p, AttributeEnumTypeQueryBuilderDsl.Of));
        }

    }
}
