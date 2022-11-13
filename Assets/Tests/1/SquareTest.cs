using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SquareTest
{
    [Test]
    public void SquareTestSimplePasses()
    {
        Square sum = ScriptableObject.CreateInstance<Square>();

        Assert.AreEqual(9, sum.Proccess(3), "Сумма не верна");
        Assert.AreEqual(16, sum.Proccess(4), "Сумма не верна");
    }

}
