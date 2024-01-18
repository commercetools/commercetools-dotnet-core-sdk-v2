// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class NotEnabledErrorQueryBuilderDsl
    {
        public NotEnabledErrorQueryBuilderDsl()
        {
        }

        public static NotEnabledErrorQueryBuilderDsl Of()
        {
            return new NotEnabledErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<NotEnabledErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<NotEnabledErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<NotEnabledErrorQueryBuilderDsl>(p, NotEnabledErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<NotEnabledErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<NotEnabledErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<NotEnabledErrorQueryBuilderDsl>(p, NotEnabledErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
