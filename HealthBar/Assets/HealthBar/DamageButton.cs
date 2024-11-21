public class DamageButton : ButtonParameters
{    
    public override void Press()
    {
        HealthCharacter.TakeDamage(Value);
    }
}
