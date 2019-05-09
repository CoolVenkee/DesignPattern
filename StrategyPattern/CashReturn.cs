using System;

namespace StrategyPattern
{
    public class CashReturn : CashSuper
    {
        private readonly double _moneyCondition;
        private readonly double _moneyReturn;

        public CashReturn(string moneyCondition, string moneyReturn)
        {
            _moneyCondition = double.Parse(moneyCondition);
            _moneyReturn = double.Parse(moneyReturn);
        }

        public override double AcceptCash(double money)
        {
            var result = money;

            if (money >= _moneyCondition)
            {
                result = money - Math.Floor(money / _moneyCondition) * _moneyReturn;
            }

            return result;
        }
    }
}