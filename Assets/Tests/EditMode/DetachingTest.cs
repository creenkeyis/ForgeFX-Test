using NUnit.Framework;
using UnityEngine;

public class DetachingTest
{
    [Test]
    public void DetachingTestSimplePasses()
    {
        Assert.AreEqual(false, DetachLimb.detached);
    }
}
