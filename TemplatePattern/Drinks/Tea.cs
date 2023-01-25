namespace DesignPatterns.TemplatePattern.Drinks
{
    internal class Tea : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("add Lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("stepping tea bag");
        }

        protected override bool WantCondimentsHook()
        {
            string input = getUserInput();
            return input.StartsWith('y');
        }
        private string getUserInput()
        {
            Console.WriteLine("Would you like Lemon on the tea cup? (y/n)");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return "no";
            }
            return input; 
        }
    }
}
