public class RestoreHealthButton : ButtonParameters
{
    public override void Press()
    {
        HealthCharacter.Restore(Value);
    }
}
