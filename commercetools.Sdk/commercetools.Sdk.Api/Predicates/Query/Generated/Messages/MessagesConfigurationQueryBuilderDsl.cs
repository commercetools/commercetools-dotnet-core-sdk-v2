// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class MessagesConfigurationQueryBuilderDsl
    {
        public MessagesConfigurationQueryBuilderDsl()
        {
        }

        public static MessagesConfigurationQueryBuilderDsl Of()
        {
            return new MessagesConfigurationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MessagesConfigurationQueryBuilderDsl, bool> Enabled()
        {
            return new ComparisonPredicateBuilder<MessagesConfigurationQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("enabled")),
            p => new CombinationQueryPredicate<MessagesConfigurationQueryBuilderDsl>(p, MessagesConfigurationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessagesConfigurationQueryBuilderDsl, long> DeleteDaysAfterCreation()
        {
            return new ComparisonPredicateBuilder<MessagesConfigurationQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterCreation")),
            p => new CombinationQueryPredicate<MessagesConfigurationQueryBuilderDsl>(p, MessagesConfigurationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
