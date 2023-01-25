namespace DesignPatterns.FacadePattern.SubSystem
{
    internal class CDPlayer
    {
        public void EnterCD(string cdName) { Console.WriteLine("playing " + cdName); }
        public void ExitCD() { Console.WriteLine("removing current cd"); }
    }
}
