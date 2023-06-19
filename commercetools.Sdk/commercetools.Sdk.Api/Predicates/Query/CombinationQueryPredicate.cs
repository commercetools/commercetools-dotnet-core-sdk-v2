using System;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public class CombinationQueryPredicate<T> : IQueryPredicate
    {
        private readonly IQueryPredicate _predicate;

        private readonly Func<T> _modelSupplier;

        public CombinationQueryPredicate(IQueryPredicate predicate, Func<T> modelSupplier)
        {
            this._predicate = predicate;
            this._modelSupplier = modelSupplier;
        }

        /**
         * combines the previous predicate with the argument predicate by an AND operator
         * @param fn predicate builder function
         * @return a combination predicate
         */
        public CombinationQueryPredicate<T> And(Func<T, CombinationQueryPredicate<T>> fn)
        {
            return new CombinationQueryPredicate<T>(
                new BinaryQueryPredicate().Left(_predicate).Right(fn.Invoke(_modelSupplier.Invoke())).Operator("and"),
                _modelSupplier);
        }

        /**
         * combines the previous predicate with the argument predicate by an AND operator
         * @param second predicate
         * @return a combination predicate
         */
        public CombinationQueryPredicate<T> And(CombinationQueryPredicate<T> second)
        {
            return new CombinationQueryPredicate<T>(new BinaryQueryPredicate().Left(_predicate).Right(second).Operator("and"),
                _modelSupplier);
        }

        /**
         * combines the previous predicate with the argument predicate by an OR operator
         * @param fn predicate builder function
         * @return a combination predicate
         */
        public CombinationQueryPredicate<T> Or(Func<T, CombinationQueryPredicate<T>> fn)
        {
            return new CombinationQueryPredicate<T>(
                new BinaryQueryPredicate().Left(_predicate).Right(fn.Invoke(_modelSupplier.Invoke())).Operator("or"),
                _modelSupplier);
        }

        /**
         * combines the previous predicate with the argument predicate by an OR operator
         * @param second predicate
         * @return a combination predicate
         */
        public CombinationQueryPredicate<T> Or(CombinationQueryPredicate<T> second)
        {
            return new CombinationQueryPredicate<T>(new BinaryQueryPredicate().Left(_predicate).Right(second).Operator("or"),
                _modelSupplier);
        }

        /**
         * puts the resulting predicate in parentheses
         * @return a combination predicate
         */
        public CombinationQueryPredicate<T> Group()
        {
            return new CombinationQueryPredicate<T>(new ContainerQueryPredicate().Inner(_predicate), _modelSupplier);
        }

        /**
         * negates the previous predicate with the NOT predicate
         * @return a combination predicate
         */
        public CombinationQueryPredicate<T> Not()
        {
            return new CombinationQueryPredicate<T>(
                new ContainerQueryPredicate().Parent(new ConstantQueryPredicate().Constant("not")).Inner(_predicate),
                _modelSupplier);
        }

        public string Render()
        {
            return _predicate.Render();
        }
    }
}