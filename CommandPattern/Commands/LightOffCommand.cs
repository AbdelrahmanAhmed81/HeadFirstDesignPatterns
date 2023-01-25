using DesignPatterns.CommandPattern;
using DesignPatterns.CommandPattern.Devices;

namespace DesignPatterns
{
    internal class LightOffCommand : ICommand
    {
        Light light;
        public LightOffCommand(Light _light)
        {
            light = _light;
        }
        public void Execute()
        {
            light.TurnLightOff();
        }

        public void Undo()
        {
            light.TurnLightOn();
        }
    }
}