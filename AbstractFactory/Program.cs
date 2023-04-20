const int SBER_ID = 1;
const int TINKOFF_ID = 2;
// See https://aka.ms/new-console-template for more information
IBankCardEmitter cardEmitter = AskChooseBank();
AskChooseCard();


void AskChooseCard()
{
    Console.WriteLine("Please Choose the card: 1 - credit; 2 - debit");
    var cardType = Console.ReadLine();
    Card? card = null; 
    if (cardType == "1"){
        card = cardEmitter.EmitCreditCard();   
    }
    else if (cardType == "2"){
        card = cardEmitter.EmitDebitCard();    
    }
    else{
        AskChooseCard();
    }
    if (card != null)
       Console.WriteLine($"Congradulations! {card.GetType()} was emitted!"); 
}

IBankCardEmitter GetCardEmitter(int bank)
{
    switch (bank)
    {
        case SBER_ID:
            return new SberBankCardEmitter();
        case TINKOFF_ID:
            return new TinkoffBankCardEmitter();
        default:            
            throw new Exception("Bank is not found");
    }
}

IBankCardEmitter AskChooseBank()
{
    Console.WriteLine($"Please Choose the bank: {SBER_ID} - Sber; {TINKOFF_ID} - Tinkoff");
    var bankStr = Console.ReadLine();
    if (!int.TryParse(bankStr, out var bank))
       return AskChooseBank();
    try {
        IBankCardEmitter cardEmitter = GetCardEmitter(bank);
        return cardEmitter;
    }
    catch {
        return AskChooseBank();
    }    
}