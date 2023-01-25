namespace DesignPatterns.FacadePattern.SubSystem
{
    internal class PopToaster
    {
        public void TurnOn()
        {
            Console.WriteLine("popcorn toaster on");
        }
        public void TurnOff()
        {
            Console.WriteLine("popcorn toaster off");
        }
         
        public void Pop()
        {
            Console.WriteLine("pop corn poped");
        }
    }
}
