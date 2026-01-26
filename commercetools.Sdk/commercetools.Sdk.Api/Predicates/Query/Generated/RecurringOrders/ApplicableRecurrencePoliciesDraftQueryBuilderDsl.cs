using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class ApplicableRecurrencePoliciesDraftQueryBuilderDsl
    {
        public ApplicableRecurrencePoliciesDraftQueryBuilderDsl()
        {
        }

        public static ApplicableRecurrencePoliciesDraftQueryBuilderDsl Of()
        {
            return new ApplicableRecurrencePoliciesDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApplicableRecurrencePoliciesDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ApplicableRecurrencePoliciesDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ApplicableRecurrencePoliciesDraftQueryBuilderDsl>(p, ApplicableRecurrencePoliciesDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApplicableRecurrencePoliciesDraftQueryBuilderDsl> RecurrencePolicies(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApplicableRecurrencePoliciesDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("recurrencePolicies"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyResourceIdentifierQueryBuilderDsl.Of())),
                ApplicableRecurrencePoliciesDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApplicableRecurrencePoliciesDraftQueryBuilderDsl> RecurrencePolicies()
        {
            return new CollectionPredicateBuilder<ApplicableRecurrencePoliciesDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("recurrencePolicies")),
                    p => new CombinationQueryPredicate<ApplicableRecurrencePoliciesDraftQueryBuilderDsl>(p, ApplicableRecurrencePoliciesDraftQueryBuilderDsl.Of));
        }

    }
}
