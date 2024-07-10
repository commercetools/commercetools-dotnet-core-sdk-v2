// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class DuplicateFieldErrorQueryBuilderDsl
    {
        public DuplicateFieldErrorQueryBuilderDsl()
        {
        }

        public static DuplicateFieldErrorQueryBuilderDsl Of()
        {
            return new DuplicateFieldErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DuplicateFieldErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<DuplicateFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<DuplicateFieldErrorQueryBuilderDsl>(p, DuplicateFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateFieldErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<DuplicateFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<DuplicateFieldErrorQueryBuilderDsl>(p, DuplicateFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateFieldErrorQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<DuplicateFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<DuplicateFieldErrorQueryBuilderDsl>(p, DuplicateFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DuplicateFieldErrorQueryBuilderDsl, string> DuplicateValue()
        {
            return new ComparisonPredicateBuilder<DuplicateFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("duplicateValue")),
            p => new CombinationQueryPredicate<DuplicateFieldErrorQueryBuilderDsl>(p, DuplicateFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
