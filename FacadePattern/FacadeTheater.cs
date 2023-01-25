using DesignPatterns.FacadePattern.SubSystem;

namespace DesignPatterns.FacadePattern
{
    internal class FacadeTheater
    {
        PopToaster popToaster;
        DVD dvd;
        CDPlayer cdPlayer;
        public FacadeTheater(PopToaster _toaster , DVD _dvd , CDPlayer _player)
        {
            popToaster = _toaster;
            dvd = _dvd;
            cdPlayer = _player;
        }

        public void PlayMovie(string movieName)
        {
            popToaster.TurnOn();
            popToaster.Pop();
            dvd.TurnDVDOn();
            cdPlayer.EnterCD(movieName);
        }

        public void StopMovie()
        {
            popToaster.TurnOff();
            dvd.TurnDVDOff();
            cdPlayer.ExitCD();
        }
    }
}
