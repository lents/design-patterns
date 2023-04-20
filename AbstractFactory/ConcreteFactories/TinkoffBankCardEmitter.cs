public class TinkoffBankCardEmitter : IBankCardEmitter
{
    public DebitCard EmitDebitCard()
    {
        return new TinkoffDebitCard();
    }

    public CreditCard EmitCreditCard()
    {
        return new TinkoffCreditCard();
    }
}