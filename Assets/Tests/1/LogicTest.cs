using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class LogicTest
{
    [Test]
    public void IsPositiveTest()
    {
        Logic logic = ScriptableObject.CreateInstance<Logic>();

        Assert.AreEqual(true, logic.IsPositive(2), "Положительное");
        Assert.AreEqual(false, logic.IsPositive(-1), "Отрицательное");
        Assert.AreEqual(true, logic.IsPositive(0), "Не отрицательное");
    }

    [Test]
    public void IsOddTest()
    {
        Logic logic = ScriptableObject.CreateInstance<Logic>();

        Assert.AreEqual("Четное", logic.IsOdd(2), "Неверно, проверка на нечетность");
        Assert.AreEqual("Четное", logic.IsOdd(4), "Неверно, проверка на нечетность");
        Assert.AreEqual("Четное", logic.IsOdd(20), "Неверно, проверка на нечетность");
        Assert.AreEqual("Нечетное", logic.IsOdd(3), "Неверно, проверка на нечетность");
        Assert.AreEqual("Нечетное", logic.IsOdd(7), "Неверно, проверка на нечетность");
        Assert.AreEqual("Нечетное", logic.IsOdd(123411), "Неверно, проверка на нечетность");

    }
}
