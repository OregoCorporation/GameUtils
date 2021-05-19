namespace GameElements
{
    public interface IEventHandler
    {
        bool isEnabled { get; set; }

        IEvent HandleEvent(IEvent inputEvent);
    }
}