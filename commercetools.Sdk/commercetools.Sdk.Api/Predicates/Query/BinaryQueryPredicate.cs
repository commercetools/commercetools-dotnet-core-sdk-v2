namespace commercetools.Sdk.Api.Predicates.Query
{
    public class BinaryQueryPredicate : IBinaryPredicate<IQueryPredicate>, IQueryPredicate
    {
        private readonly IQueryPredicate _left;
        private readonly IQueryPredicate _right;
        private readonly string _op;

        public BinaryQueryPredicate(IQueryPredicate left, IQueryPredicate right, string op)
        {
            this._left = left;
            this._right = right;
            this._op = op;
        }

        public BinaryQueryPredicate()
        {
            this._left = null;
            this._right = null;
            this._op = null;
        }

        public static BinaryQueryPredicate Of()
        {
            return new BinaryQueryPredicate();
        }

        public IQueryPredicate Left()
        {
            return _left;
        }

        public IQueryPredicate Right()
        {
            return _right;
        }

        public string Operator()
        {
            return _op;
        }

        public BinaryQueryPredicate Left(IQueryPredicate predicate)
        {
            return new BinaryQueryPredicate(predicate, _right, _op);
        }

        public BinaryQueryPredicate Right(IQueryPredicate predicate)
        {
            return new BinaryQueryPredicate(_left, predicate, _op);
        }

        public BinaryQueryPredicate Operator(string op)
        {
            return new BinaryQueryPredicate(_left, _right, op);
        }

        public string Render()
        {
            // if the operator is empty or null, then remove it to avoid double spaces
            return string.IsNullOrWhiteSpace(Operator()) ?
                $"{Left().Render()} {Right().Render()}".Trim() :
                $"{Left().Render()} {Operator()} {Right().Render()}".Trim();
        }
    }
}