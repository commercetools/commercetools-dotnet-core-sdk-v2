using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeSetDescriptionActionQueryBuilderDsl
    {
        public DiscountCodeSetDescriptionActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeSetDescriptionActionQueryBuilderDsl Of()
        {
            return new DiscountCodeSetDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeSetDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeSetDescriptionActionQueryBuilderDsl>(p, DiscountCodeSetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeSetDescriptionActionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeSetDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                DiscountCodeSetDescriptionActionQueryBuilderDsl.Of);
        }


    }
}
