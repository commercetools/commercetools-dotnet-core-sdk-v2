// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.QuoteRequests
{

    public partial class QuoteRequestSetCustomFieldActionQueryBuilderDsl
    {
        public QuoteRequestSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static QuoteRequestSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new QuoteRequestSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<QuoteRequestSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<QuoteRequestSetCustomFieldActionQueryBuilderDsl>(p, QuoteRequestSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<QuoteRequestSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<QuoteRequestSetCustomFieldActionQueryBuilderDsl>(p, QuoteRequestSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteRequestSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<QuoteRequestSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<QuoteRequestSetCustomFieldActionQueryBuilderDsl>(p, QuoteRequestSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
