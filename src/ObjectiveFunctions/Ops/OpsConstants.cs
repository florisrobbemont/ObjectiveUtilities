using System.Text;
using System.Text.RegularExpressions;

namespace ObjectiveFunctions.Ops
{
    public static class OpsConstants
    {
        public static readonly Regex OpsCodeRegex = new Regex("([mMfF?])([mMfF?])-?([nNsSfFtTeEiIOoDd][nNsSfFtTeEiI])\\/?([nNsSfFtTeEiI][nNsSfFtTeEiI])-?([cCsSpPbB])([cCsSpPbB])\\/?([cCsSpPbB])\\(?([cCsSpPbB])\\)?", RegexOptions.Compiled);

        public static class Functions
        {
            public const string Ti = "TI";
            public const string Te = "TE";

            public const string Fi = "FI";
            public const string Fe = "FE";

            public const string Ni = "NI";
            public const string Ne = "NE";

            public const string Si = "SI";
            public const string Se = "SE";

            public const string Oi = "OI";
            public const string Oe = "OE";

            public const string Di = "DI";
            public const string De = "DE";
        }

        public static class Animals
        {
            public const string Consume = "C";
            public const string Sleep = "S";
            public const string Play = "P";
            public const string Blast = "B";
        }

        public static OpsCoins GetCoins(this string type)
        {
            var match = OpsCodeRegex.Match(type);

            if (match?.Success == false)
                return OpsCoins.None;

            var coins = OpsCoins.None;
            for (var i = 1; i < match.Groups.Count; i++)
            {
                var value = match.Groups[i].Value.ToUpper();

                switch (i)
                {
                    // Modalities
                    case 1:
                        SetSensory(value);
                        break;
                    case 2:
                        SetExtravertDecider(value);
                        break;

                    // Functions
                    case 3:
                        SetFirstSavior(value);
                        break;
                    case 4:
                        SetSecondSavior(value);
                        break;

                    // Animals
                    case 5:
                        SetFirstAnimal(value);
                        break;
                    case 6:
                        SetSecondAnimal(value);
                        break;
                    case 8:
                        SetLastAnimal(value);
                        break;
                }
            }

            void SetSensory(string coin)
            {
                switch (coin)
                {
                    case "M":
                        coins |= OpsCoins.MasculineSensory;
                        break;
                    case "F":
                        coins |= OpsCoins.FeminineSensory;
                        break;
                    default:
                        coins |= OpsCoins.UnknownSensory;
                        break;
                }
            }
            void SetExtravertDecider(string coin)
            {
                switch (coin)
                {
                    case "M":
                        coins |= OpsCoins.MasculineDe;
                        break;
                    case "F":
                        coins |= OpsCoins.FeminineDe;
                        break;
                    default:
                        coins |= OpsCoins.UnknownDe;
                        break;
                }
            }
            void SetFirstSavior(string coin)
            {
                switch (coin)
                {
                    case Functions.Ti:
                        coins |= OpsCoins.Thinking | OpsCoins.Decider | OpsCoins.Di;
                        break;
                    case Functions.Te:
                        coins |= OpsCoins.Thinking | OpsCoins.Decider | OpsCoins.De;
                        break;

                    case Functions.Fi:
                        coins |= OpsCoins.Feeling | OpsCoins.Decider | OpsCoins.Di;
                        break;
                    case Functions.Fe:
                        coins |= OpsCoins.Feeling | OpsCoins.Decider | OpsCoins.De;
                        break;

                    case Functions.Ni:
                        coins |= OpsCoins.Intuition | OpsCoins.Observer | OpsCoins.Oi;
                        break;
                    case Functions.Ne:
                        coins |= OpsCoins.Intuition | OpsCoins.Observer | OpsCoins.Oe;
                        break;

                    case Functions.Si:
                        coins |= OpsCoins.Sensing | OpsCoins.Observer | OpsCoins.Oi;
                        break;
                    case Functions.Se:
                        coins |= OpsCoins.Sensing | OpsCoins.Observer | OpsCoins.Oe;
                        break;

                    // Unknowns
                    case Functions.Oi:
                        coins |= OpsCoins.Observer | OpsCoins.Oi;
                        break;
                    case Functions.Oe:
                        coins |= OpsCoins.Observer | OpsCoins.Oe;
                        break;

                    case Functions.Di:
                        coins |= OpsCoins.Decider | OpsCoins.Di;
                        break;
                    case Functions.De:
                        coins |= OpsCoins.Decider | OpsCoins.De;
                        break;
                }
            }
            void SetSecondSavior(string coin)
            {
                switch (coin)
                {
                    case Functions.Ti:
                        coins |= OpsCoins.Thinking | OpsCoins.Di;
                        break;
                    case Functions.Te:
                        coins |= OpsCoins.Thinking | OpsCoins.De;
                        break;

                    case Functions.Fi:
                        coins |= OpsCoins.Feeling | OpsCoins.Di;
                        break;
                    case Functions.Fe:
                        coins |= OpsCoins.Feeling | OpsCoins.De;
                        break;

                    case Functions.Ni:
                        coins |= OpsCoins.Intuition | OpsCoins.Oi;
                        break;
                    case Functions.Ne:
                        coins |= OpsCoins.Intuition | OpsCoins.Oe;
                        break;

                    case Functions.Si:
                        coins |= OpsCoins.Sensing | OpsCoins.Oi;
                        break;
                    case Functions.Se:
                        coins |= OpsCoins.Sensing | OpsCoins.Oe;
                        break;
                        
                    // Unknowns
                    case Functions.Oi:
                        coins |= OpsCoins.Oi;
                        break;
                    case Functions.Oe:
                        coins |= OpsCoins.Oe;
                        break;

                    case Functions.Di:
                        coins |= OpsCoins.Di;
                        break;
                    case Functions.De:
                        coins |= OpsCoins.De;
                        break;
                }
            }
            void SetFirstAnimal(string coin)
            {
                switch (coin)
                {
                    case Animals.Consume:
                        coins |= OpsCoins.ConsumeOverBlast | OpsCoins.Oe;
                        break;
                    case Animals.Blast:
                        coins |= OpsCoins.BlastOverConsume | OpsCoins.Oi;
                        break;

                    case Animals.Sleep:
                        coins |= OpsCoins.SleepOverPlay | OpsCoins.Oi;
                        break;
                    case Animals.Play:
                        coins |= OpsCoins.PlayOverSleep | OpsCoins.Oe;
                        break;
                }
            }
            void SetSecondAnimal(string coin)
            {
                switch (coin)
                {
                    case Animals.Consume:
                        coins |= OpsCoins.ConsumeOverBlast;
                        break;
                    case Animals.Blast:
                        coins |= OpsCoins.BlastOverConsume;
                        break;

                    case Animals.Sleep:
                        coins |= OpsCoins.SleepOverPlay;
                        break;
                    case Animals.Play:
                        coins |= OpsCoins.PlayOverSleep;
                        break;
                }
            }
            void SetLastAnimal(string coin)
            {
                switch (coin)
                {
                    case Animals.Consume:
                        coins |= OpsCoins.ConsumeLast | OpsCoins.Energy;
                        break;
                    case Animals.Blast:
                        coins |= OpsCoins.BlastLast | OpsCoins.Energy;
                        break;

                    case Animals.Sleep:
                        coins |= OpsCoins.SleepLast | OpsCoins.Info;
                        break;
                    case Animals.Play:
                        coins |= OpsCoins.PlayLast | OpsCoins.Info;
                        break;
                }
            }

            return coins;
        }
    }
}
