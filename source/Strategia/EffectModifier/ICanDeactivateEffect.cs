namespace Strategia
{
    public interface ICanDeactivateEffect
    {
        bool CanDeactivate(ref string reason);
    }
}
