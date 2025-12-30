namespace Strategia
{
    public interface IRequirementEffect
    {
        bool RequirementMet(out string unmetReason);
        string RequirementText();
    }
}
