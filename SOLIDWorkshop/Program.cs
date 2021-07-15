namespace SOLIDWorkshop
{
    public class Program
    {
        public void Main(string[] args)
        {
            var bankManager = new BankManager();
            bankManager.TransferAmount(1, 2, 50);
        }
    }
}