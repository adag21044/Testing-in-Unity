using NUnit.Framework;
using UnityEngine;

public class CubeManagerTests
{
    [Test]
    public void TakeDamage_ShouldReduceHealth()
    {
        var gameObject = new GameObject();
        var cubeManager = gameObject.AddComponent<CubeManager>();

        cubeManager.TakeDamage(20);

        Assert.AreEqual(80, cubeManager.health);
    }

    [Test]
    public void AddScore_ShouldIncreaseScore()
    {
        var gameObject = new GameObject();
        var cubeManager = gameObject.AddComponent<CubeManager>();

        cubeManager.AddScore(10);

        Assert.AreEqual(10, cubeManager.score);
    }

    [Test]
    public void TakeDamage_ShouldNotAllowNegativeHealth()
    {
        var gameObject = new GameObject();
        var cubeManager = gameObject.AddComponent<CubeManager>();

        cubeManager.TakeDamage(200);

        Assert.AreEqual(0, cubeManager.health);
    }
}
