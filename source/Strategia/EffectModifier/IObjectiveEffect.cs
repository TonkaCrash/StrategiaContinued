using System.Collections.Generic;

namespace Strategia
{
    public interface IObjectiveEffect
    {
        IEnumerable<string> ObjectiveText();

        double rewardFunds { get; }
        float rewardScience { get; }
        float rewardReputation { get; }
        double failureFunds { get; }
        float failureScience { get; }
        float failureReputation { get; }
        double advanceFunds { get; }
        float advanceScience { get; }
        float advanceReputation { get; }
    }
}
