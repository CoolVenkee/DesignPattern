namespace StrategyPattern
{
    public class CashContext
    {
        private CashSuper _cs;

        public CashContext(string type)
        {
            switch (type)
            {
                case "满300返100":
                    _cs = new CashReturn("300", "100");
                    break;
                case "打8折":
                    _cs = new CashRebate("0.8");
                    break;
                case "打7折":
                    _cs = new CashRebate("0.7");
                    break;
                case "打5折":
                    _cs = new CashRebate("0.5");
                    break;
                default:
                    _cs = new CashNormal();
                    break;
            }
        }

        public double GetResult(double money)
        {
            return _cs.AcceptCash(money);
        }
    }
}