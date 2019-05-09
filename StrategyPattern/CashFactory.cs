namespace StrategyPattern
{
    public class CashFactory
    {
        public static CashSuper CreateCashAccept(string type)
        {
            CashSuper cs;

            switch (type)
            {
                case "满300返100":
                    cs = new CashReturn("300", "100");
                    break;
                case "打8折":
                    cs = new CashRebate("0.8");
                    break;
                case "打7折":
                    cs = new CashRebate("0.7");
                    break;
                case "打5折":
                    cs = new CashRebate("0.5");
                    break;
                default:
                    cs = new CashNormal();
                    break;
            }

            return cs;
        }
    }
}