namespace DesignPatterns.CommandPattern.Devices
{
    internal class GarageDoor
    {
        public void LiftUp()
        {
            Console.WriteLine("Raising Up Garage Door");
        }
        public void LowerDown()
        {
            Console.WriteLine("Lowering Garage Door");
        }
    }
}
