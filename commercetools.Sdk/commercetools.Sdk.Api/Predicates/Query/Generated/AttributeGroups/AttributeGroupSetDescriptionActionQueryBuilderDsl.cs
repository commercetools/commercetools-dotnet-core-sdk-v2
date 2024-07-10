using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeGroupSetDescriptionActionQueryBuilderDsl
    {
        public AttributeGroupSetDescriptionActionQueryBuilderDsl()
        {
        }

        public static AttributeGroupSetDescriptionActionQueryBuilderDsl Of()
        {
            return new AttributeGroupSetDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeGroupSetDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<AttributeGroupSetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<AttributeGroupSetDescriptionActionQueryBuilderDsl>(p, AttributeGroupSetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AttributeGroupSetDescriptionActionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AttributeGroupSetDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                AttributeGroupSetDescriptionActionQueryBuilderDsl.Of);
        }


    }
}
