// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class LockedFieldErrorQueryBuilderDsl
    {
        public LockedFieldErrorQueryBuilderDsl()
        {
        }

        public static LockedFieldErrorQueryBuilderDsl Of()
        {
            return new LockedFieldErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<LockedFieldErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<LockedFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<LockedFieldErrorQueryBuilderDsl>(p, LockedFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LockedFieldErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<LockedFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<LockedFieldErrorQueryBuilderDsl>(p, LockedFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LockedFieldErrorQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<LockedFieldErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<LockedFieldErrorQueryBuilderDsl>(p, LockedFieldErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
