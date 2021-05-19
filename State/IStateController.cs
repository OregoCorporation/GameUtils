using System;

namespace GameElements
{
    public interface IStateController
    {
        event Action<IState, IStateTransition> OnStateChangedEvent;

        T GetCurrentState<T>() where T : IState;

        void SetCurrentState(IState nextState, IStateTransition transition = null);
    }
}