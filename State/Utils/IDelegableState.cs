namespace GameElements
{
    public interface IDelegableState : IState 
    {
        void OnProvideParent(object parent);
    }
}