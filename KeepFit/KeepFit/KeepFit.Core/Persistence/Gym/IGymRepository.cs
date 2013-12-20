﻿using System.Collections.Generic;

namespace KeepFit.Core.Persistence.Gym
{
    public interface IGymRepository
    {
        Domain.Gym.Gym AddGym(Domain.Gym.Gym gym);
        IEnumerable<Domain.Gym.Gym> GetGyms();
    }
}
