namespace Billing_System
{
    public class BillingService
    {
        private string input;
        private int countApple;
        private int countAvocadoes;
        

        public BillingService(string input)
        {
            this.input = input;
            ParseInput();
        }

        private void ParseInput()
        {
            string[] str = input.Split('[')[1].Split(']')[0].Split(',');
            foreach (var item in str)
            {
                switch (item.ToLower().Trim())
                {
                    case "apple":
                        countApple++;
                        break;
                    case "avocado":
                        countAvocadoes++;
                        break;
                    default:break;
                }
            }

        }

        public decimal CalculateTotalPrice()
        {
            return (countApple - countApple / 3) * 0.25m + countAvocadoes * 0.1m;
        }
    }
}