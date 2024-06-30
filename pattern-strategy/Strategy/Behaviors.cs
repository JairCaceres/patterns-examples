using pattern_strategy.Interfaces;

namespace pattern_strategy.Strategy
{
    public class PayByCreditCardBehavior : IBehavior
    {
        public void DoBehavior()
        {
            Console.WriteLine("Possibility of paying in multiple installments");
        }
    }

    public class PayByDebitCardBehavior : IBehavior
    {
        public void DoBehavior()
        {
            Console.WriteLine("Only being able to pay in a single installment");
        }
    }
}
