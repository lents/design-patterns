public class SberBankCardEmitter : IBankCardEmitter
{
    public DebitCard EmitDebitCard()
    {
        return new SberDebitCard();
    }

    public CreditCard EmitCreditCard()
    {
        return new SberCreditCard();
    }
}