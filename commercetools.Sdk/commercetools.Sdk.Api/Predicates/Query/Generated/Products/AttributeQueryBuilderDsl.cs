using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class AttributeQueryBuilderDsl
    {
        public AttributeQueryBuilderDsl()
        {
        }

        public static AttributeQueryBuilderDsl Of()
        {
            return new AttributeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeQueryBuilderDsl>(p, AttributeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<AttributeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<AttributeQueryBuilderDsl>(p, AttributeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
