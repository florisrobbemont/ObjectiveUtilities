namespace ObjectiveFunctions.Ops
{
    public class OpsType
    {
        private readonly OpsCoins type;

        public int TypeCode => (int) type;
        public string OriginalType { get; }
        public string TypeDescription => type.ToString();
        
        public bool? MasculineSensory => type.HasFlag(OpsCoins.UnknownSensory) ? (bool?)null : type.HasFlag(OpsCoins.MasculineSensory);
        public bool? MasculineDe => type.HasFlag(OpsCoins.UnknownDe) ? (bool?)null : type.HasFlag(OpsCoins.MasculineDe);
       
        public bool Decider => type.HasFlag(OpsCoins.Decider);
        public bool Observer => type.HasFlag(OpsCoins.Observer);

        public bool Oi => type.HasFlag(OpsCoins.Oi);
        public bool Oe => type.HasFlag(OpsCoins.Oe);
        public bool Di => type.HasFlag(OpsCoins.Di);
        public bool De => type.HasFlag(OpsCoins.De);

        public bool Sensing => type.HasFlag(OpsCoins.Sensing);
        public bool Intuition => type.HasFlag(OpsCoins.Intuition);
        public bool Feeling => type.HasFlag(OpsCoins.Feeling);
        public bool Thinking => type.HasFlag(OpsCoins.Thinking);

        public bool ConsumeOverBlast => type.HasFlag(OpsCoins.ConsumeOverBlast);
        public bool BlastOverConsume => type.HasFlag(OpsCoins.BlastOverConsume);
        public bool SleepOverPlay => type.HasFlag(OpsCoins.SleepOverPlay);
        public bool PlayOverSleep => type.HasFlag(OpsCoins.PlayOverSleep);

        public bool SleepLast => type.HasFlag(OpsCoins.SleepLast);
        public bool ConsumeLast => type.HasFlag(OpsCoins.ConsumeLast);
        public bool BlastLast => type.HasFlag(OpsCoins.BlastLast);
        public bool PlayLast => type.HasFlag(OpsCoins.PlayLast);

        public bool Energy => type.HasFlag(OpsCoins.Energy);
        public bool Info => type.HasFlag(OpsCoins.Info);

        public OpsType(OpsCoins type)
        {
            this.type = type;
        }

        public OpsType(string type) 
            : this(type.GetCoins())
        {
            OriginalType = type;
        }
    }
}