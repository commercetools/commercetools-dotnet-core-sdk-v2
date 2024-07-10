using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class DuplicateVariantValuesErrorQueryBuilderDsl
    {
        public DuplicateVariantValuesErrorQueryBuilderDsl()
        {
        }

        public static DuplicateVariantValuesErrorQueryBuilderDsl Of()
        {
            return new DuplicateVariantValuesErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DuplicateVariantValuesErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<DuplicateVariantValuesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<DuplicateVariantValuesErrorQueryBuilderDsl>(p, DuplicateVariantValuesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateVariantValuesErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<DuplicateVariantValuesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<DuplicateVariantValuesErrorQueryBuilderDsl>(p, DuplicateVariantValuesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DuplicateVariantValuesErrorQueryBuilderDsl> VariantValues(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.VariantValuesQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.VariantValuesQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DuplicateVariantValuesErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variantValues"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.VariantValuesQueryBuilderDsl.Of())),
                DuplicateVariantValuesErrorQueryBuilderDsl.Of);
        }


    }
}
