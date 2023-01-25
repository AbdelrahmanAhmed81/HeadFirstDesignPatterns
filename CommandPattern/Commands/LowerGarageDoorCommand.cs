using DesignPatterns.CommandPattern.Devices;

namespace DesignPatterns.CommandPattern.Commands
{
    internal class LowerGarageDoorCommand : ICommand
    {
        GarageDoor door;
        public LowerGarageDoorCommand(GarageDoor _door)
        {
            door = _door;
        }
        public void Execute()
        {
            door.LowerDown();
        }
        public void Undo()
        {
            door.LiftUp();
        }
    }
}
