using DesignPatterns.CommandPattern;
using DesignPatterns.CommandPattern.Devices;

namespace DesignPatterns
{
    internal class RaiseGarageDoorCommand : ICommand
    {
        GarageDoor door;
        public RaiseGarageDoorCommand(GarageDoor _door)
        {
            door = _door;
        }
        public void Execute()
        {
            door.LiftUp();
        }
        public void Undo()
        {
            door.LowerDown();
        }
    }
}