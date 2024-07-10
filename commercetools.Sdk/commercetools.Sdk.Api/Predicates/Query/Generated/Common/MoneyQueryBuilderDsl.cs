using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class MoneyQueryBuilderDsl
    {
        public MoneyQueryBuilderDsl()
        {
        }

        public static MoneyQueryBuilderDsl Of()
        {
            return new MoneyQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MoneyQueryBuilderDsl, long> CentAmount()
        {
            return new ComparisonPredicateBuilder<MoneyQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("centAmount")),
            p => new CombinationQueryPredicate<MoneyQueryBuilderDsl>(p, MoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MoneyQueryBuilderDsl, string> CurrencyCode()
        {
            return new ComparisonPredicateBuilder<MoneyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currencyCode")),
            p => new CombinationQueryPredicate<MoneyQueryBuilderDsl>(p, MoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<MoneyQueryBuilderDsl> AsTypedMoney(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MoneyQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of()),
                MoneyQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MoneyQueryBuilderDsl> AsTypedMoneyDraft(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MoneyQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyDraftQueryBuilderDsl.Of()),
                MoneyQueryBuilderDsl.Of);
        }
    }
}
