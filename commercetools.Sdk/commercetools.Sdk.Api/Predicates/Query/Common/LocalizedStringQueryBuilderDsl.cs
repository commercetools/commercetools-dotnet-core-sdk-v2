
namespace commercetools.Sdk.Api.Predicates.Query.Common
{
    public partial class LocalizedStringQueryBuilderDsl
    {
        public IComparisonPredicateBuilder<LocalizedStringQueryBuilderDsl, string> With(string locale)
        {
            return new ComparisonPredicateBuilder<LocalizedStringQueryBuilderDsl, string>(
                BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate(locale)),
                p => new CombinationQueryPredicate<LocalizedStringQueryBuilderDsl>(p, LocalizedStringQueryBuilderDsl.Of),
                PredicateFormatter.Format);
        }
    }
}
