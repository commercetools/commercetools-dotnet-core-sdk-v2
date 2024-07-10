using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeGroupChangeNameActionQueryBuilderDsl
    {
        public AttributeGroupChangeNameActionQueryBuilderDsl()
        {
        }

        public static AttributeGroupChangeNameActionQueryBuilderDsl Of()
        {
            return new AttributeGroupChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeGroupChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AttributeGroupChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AttributeGroupChangeNameActionQueryBuilderDsl>(p, AttributeGroupChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeGroupChangeNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupChangeNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AttributeGroupChangeNameActionQueryBuilderDsl.Of);
        }


    }
}
