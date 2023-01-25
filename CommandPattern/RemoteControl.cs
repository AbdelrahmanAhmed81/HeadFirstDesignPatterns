using System.Text;

namespace DesignPatterns.CommandPattern
{
    internal class RemoteControl
    {
        ICommand[] onSlots = new ICommand[7];
        ICommand[] offSlots = new ICommand[7];
        ICommand lastCommand;
        public void SetCommand(int slotIndex , ICommand onCommand , ICommand offCommand)
        {
            onSlots[slotIndex] = onCommand;
            offSlots[slotIndex] = offCommand;
        }
        public void PressOnButton(int slotIndex)
        {
            if (onSlots[slotIndex] != null)
            {
                onSlots[slotIndex].Execute();
                lastCommand = onSlots[slotIndex];
            }
        }
        public void PressOffButton(int slotIndex)
        {
            if (offSlots[slotIndex] != null)
            {
                offSlots[slotIndex].Execute();
                lastCommand = offSlots[slotIndex];
            }
        }
        public void Undo()
        {
            if (lastCommand != null)
                lastCommand.Undo();
        }
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("------------- Remote Control -------------");
            for (int i = 0 ; i < 7 ; i++)
            {
                result.AppendLine($"slot {i}: On Command for {onSlots[i]} | Off Command for {offSlots[i]}");
            }
            result.AppendLine("------------------------------------------");

            return result.ToString();
        }
    }
}
