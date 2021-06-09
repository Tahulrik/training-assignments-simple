public abstract class BankAccount
{
    private static readonly float INTEREST_PERCENTAGE = 0.01f;
    protected Money balance = new Money();
    protected int transferLimit = 100;
    
    public void addInterest()
    {
        Money interest = balance.multiply(INTEREST_PERCENTAGE);
        if (interest.greaterThan(0)) {
            balance.add(interest);
        } else {
            balance.substract(interest);
        }
    }
}