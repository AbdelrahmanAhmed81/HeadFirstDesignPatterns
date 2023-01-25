using DesignPatterns.CommandPattern.Devices;

namespace DesignPatterns.CommandPattern.Commands
{
    internal class LightOnCommand : ICommand
    {
        Light light;
        public LightOnCommand(Light _light)
        {
            light = _light;
        }
        public void Execute()
        {
            light.TurnLightOn();
        }
        public void Undo()
        {
            light.TurnLightOff();
        }
    }
}
