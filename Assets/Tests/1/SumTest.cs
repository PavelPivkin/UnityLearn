using NUnit.Framework;
using UnityEngine;

public class SumTest
{
    [Test]
    public void SumTestSimplePasses()
    {
        Sum sum = ScriptableObject.CreateInstance<Sum>();

        Assert.AreEqual(7, sum.Proccess(3, 4), "Сумма не верна");
        Assert.AreEqual(1, sum.Proccess(4, -3), "Сумма не верна");
    }
}
