using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeGroupSetKeyActionQueryBuilderDsl
    {
        public AttributeGroupSetKeyActionQueryBuilderDsl()
        {
        }

        public static AttributeGroupSetKeyActionQueryBuilderDsl Of()
        {
            return new AttributeGroupSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeGroupSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AttributeGroupSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AttributeGroupSetKeyActionQueryBuilderDsl>(p, AttributeGroupSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeGroupSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AttributeGroupSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AttributeGroupSetKeyActionQueryBuilderDsl>(p, AttributeGroupSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
