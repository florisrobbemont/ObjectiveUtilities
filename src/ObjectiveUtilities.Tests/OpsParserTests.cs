using NUnit.Framework;
using ObjectiveFunctions.Ops;

namespace ObjectiveUtilities.Tests
{
    public class OpsParserTests
    {
        [Test]
        public void SelfishTestAboutMyType()
        {
            var coins = "MF-Ti/Se-CS/P(B)".GetCoins();

            Assert.IsTrue(coins.HasFlag(OpsCoins.Sensing));
            Assert.IsTrue(coins.HasFlag(OpsCoins.Di));
            Assert.IsTrue(coins.HasFlag(OpsCoins.Thinking));
            Assert.IsTrue(coins.HasFlag(OpsCoins.Decider));
            Assert.IsTrue(coins.HasFlag(OpsCoins.Energy));
            Assert.IsTrue(coins.HasFlag(OpsCoins.ConsumeOverBlast));
            Assert.IsTrue(coins.HasFlag(OpsCoins.SleepOverPlay));
            Assert.IsTrue(coins.HasFlag(OpsCoins.BlastLast));
            Assert.IsTrue(coins.HasFlag(OpsCoins.MasculineSensory));
            Assert.IsTrue(coins.HasFlag(OpsCoins.FeminineDe));

            Assert.IsFalse(coins.HasFlag(OpsCoins.Intuition));
            Assert.IsFalse(coins.HasFlag(OpsCoins.De));
            Assert.IsFalse(coins.HasFlag(OpsCoins.Observer));
            Assert.IsFalse(coins.HasFlag(OpsCoins.Feeling));
        }
    }
}