using System;

namespace Android14Timezone
{
    public interface ITimeServices
    {
        String ToLocalTime(long unix);
    }
}