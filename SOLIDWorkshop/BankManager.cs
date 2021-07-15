using System;

namespace SOLIDWorkshop
{
    public class BankManager
    {
        public void TransferAmount(int fromAccountId, int toAccountId, int amount)
        {
            var fromAccount = new Account
            {
                Id = fromAccountId,
                Amount = Database.Accounts[fromAccountId]
            };
            
            var toAccount = new Account
            {
                Id = toAccountId,
                Amount = Database.Accounts[toAccountId]
            };

            fromAccount.Amount -= amount;
            Console.WriteLine("From account: " + fromAccount.Amount);
            
            toAccount.Amount += amount;
            Console.WriteLine("To account: " + toAccount.Amount);
        }
    }
}