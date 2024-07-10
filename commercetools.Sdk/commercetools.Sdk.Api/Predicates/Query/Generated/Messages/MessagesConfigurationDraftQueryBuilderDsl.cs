using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class MessagesConfigurationDraftQueryBuilderDsl
    {
        public MessagesConfigurationDraftQueryBuilderDsl()
        {
        }

        public static MessagesConfigurationDraftQueryBuilderDsl Of()
        {
            return new MessagesConfigurationDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MessagesConfigurationDraftQueryBuilderDsl, bool> Enabled()
        {
            return new ComparisonPredicateBuilder<MessagesConfigurationDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("enabled")),
            p => new CombinationQueryPredicate<MessagesConfigurationDraftQueryBuilderDsl>(p, MessagesConfigurationDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MessagesConfigurationDraftQueryBuilderDsl, long> DeleteDaysAfterCreation()
        {
            return new ComparisonPredicateBuilder<MessagesConfigurationDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterCreation")),
            p => new CombinationQueryPredicate<MessagesConfigurationDraftQueryBuilderDsl>(p, MessagesConfigurationDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
