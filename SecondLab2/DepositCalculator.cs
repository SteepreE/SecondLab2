namespace SecondLab2
{
    class DepositCalculator
    {
        private double _percent;
        private double _depositSize;
        public struct Result
        {
            public int a;
            public int b;
        }

        public DepositCalculator(double depositSize, double percent)
        {
            _depositSize = depositSize;
            _percent = percent;
        }

        public Result Calculate(double b, double c)
        {
            Result result = new Result { a = 0, b = 0 };

            if (_depositSize == 0) return result;

            for (; (_depositSize * _percent < b || _depositSize < c); _depositSize *= (1 + _percent))
            {
                if (_depositSize * _percent < b) result.a++;
                if (_depositSize < c) result.b++;
            }

            return result;
        }
    }
}
