

public class EntityState
{
    protected StateMachine stateMachine;

    // Constructur
    public EntityState(StateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
    public virtual void Enter()
    {

    }
    public virtual void Update()
    {

    }
    public virtual void Exit()
    {

    }
}
