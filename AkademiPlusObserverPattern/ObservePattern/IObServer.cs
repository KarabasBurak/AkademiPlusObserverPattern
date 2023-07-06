using AkademiPlusObserverPattern.DAL;

namespace AkademiPlusObserverPattern.ObservePattern
{
    public interface IObServer
    {
        void CreateNewUser(AppUser appUser);
    }
}
