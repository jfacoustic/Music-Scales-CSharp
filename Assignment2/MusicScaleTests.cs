using System;
using NUnit.Framework;

namespace MusicLib
{
    [TestFixture]
    public class MusicTest
    {
        [Test]
        public void TestAFrequency()
        {
            MusicNote A = new MusicNote(Chromatic.A);
            Assert.AreEqual(440, A.Frequency());
        }
        [Test]
        public void TestCsFrequency()
        {
            MusicNote Cs = new MusicNote(Chromatic.Cs);
            Assert.AreEqual(554.37,Cs.Frequency());
        }
    }
    [TestFixture]
    public class MajorScaleTest
    {
        [Test]
        public void TestCMajorScale()
        {
            MajorScale Cmajor = new MajorScale(Chromatic.C);

            Assert.AreEqual(Chromatic.D, Cmajor.NextNote());
            Assert.AreEqual(Chromatic.E, Cmajor.NextNote());
            Assert.AreEqual(Chromatic.F, Cmajor.NextNote());
            Assert.AreEqual(Chromatic.G, Cmajor.NextNote());
            Assert.AreEqual(Chromatic.A, Cmajor.NextNote());
            Assert.AreEqual(Chromatic.B, Cmajor.NextNote());
            Assert.AreEqual(Chromatic.C, Cmajor.NextNote());
            Assert.AreEqual(Chromatic.D, Cmajor.NextNote());
        }
        [Test]
        public void TestCsMajor()
        {
            MajorScale CsMajor = new MajorScale(Chromatic.Cs);

            Assert.AreEqual(Chromatic.Ds, CsMajor.NextNote());
            Assert.AreEqual(Chromatic.F, CsMajor.NextNote());
        }
        [Test]
        public void TestAMajorFrequency()
        {
            MajorScale AMajor = new MajorScale(Chromatic.A);
            Assert.AreEqual(Chromatic.B, AMajor.NextNote());
            Assert.AreEqual(493.88, AMajor.Frequency());
        }
    }
    [TestFixture]
    public class NaturalMinorScaleTest
    {
        [Test]
        public void TestAMinorScale()
        {
            NaturalMinorScale AMinor = new NaturalMinorScale(Chromatic.A);
            Assert.AreEqual(Chromatic.B, AMinor.NextNote());
            Assert.AreEqual(Chromatic.C, AMinor.NextNote());
        }
    }
}
