using NUnit.Framework;
using UnityEngine;

public class Test
{
    [Test]
    public void SumTestPasses()
    {
        Assert.AreEqual(8, Mathematics.Sum(3, 5), "Сумма не верна");
    }

    [Test]
    public void MaxTestPasses()
    {
        Assert.AreEqual(5, Mathematics.Max(3, 5), "1. Неверный максимум");
        Assert.AreEqual(3, Mathematics.Max(3, -5), "2. Неверный максимум");
    }

    [Test]
    public void ModuleTestPasses()
    {
        Assert.AreEqual(5, Mathematics.Module(-5, 5), "1. Модуль числа неверный");
        Assert.AreEqual(3, Mathematics.Module(5, 5), "2. Модуль числа неверный");
    }
}
