using System;

namespace ObjectiveFunctions.Ops
{
    [Flags]
    public enum OpsCoins
    {
        None = 0,
        MasculineSensory = (1 << 0),
        FeminineSensory = (1 << 1),
        MasculineDe = (1 << 2),
        FeminineDe = (1 << 3),
        Decider = (1 << 4),
        Observer = (1 << 5),
        Oi = (1 << 6),
        Oe = (1 << 7),
        Di = (1 << 8),
        De = (1 << 9),
        Sensing = (1 << 10),
        Intuition = (1 << 11),
        Feeling = (1 << 12),
        Thinking = (1 << 13),
        ConsumeOverBlast = (1 << 14),
        BlastOverConsume = (1 << 15),
        SleepOverPlay = (1 << 16),
        PlayOverSleep = (1 << 17),
        SleepLast = (1 << 18),
        ConsumeLast = (1 << 19),
        BlastLast = (1 << 20),
        PlayLast = (1 << 21),
        Energy = (1 << 22),
        Info = (1 << 23),
        UnknownSensory = (1 << 24),
        UnknownDe = (1 << 25),
    }
}