using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl
    {
        public DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl()
        {
        }

        public static DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl Of()
        {
            return new DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl>(p, DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl>(p, DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl>(p, DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string> DuplicateValue()
        {
            return new ComparisonPredicateBuilder<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("duplicateValue")),
            p => new CombinationQueryPredicate<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl>(p, DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl> ConflictingResource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("conflictingResource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl.Of);
        }


    }
}
