using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RML.Core
{
public sealed class DefaultTimerFactory : TimerAbstractFactory
{
    public override ITimer CreateTimer(float duration,
        Action onComplete,
        Action<float> onTick = null,
        bool looping = false,
        bool useRealTime = false)
    {
        return DefaultTimer.CreateTimer(duration, onComplete, onTick, looping, useRealTime);
    }
}

}

