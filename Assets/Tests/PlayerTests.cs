using NUnit.Framework;
using UnityEngine;

public class PlayerTests
{
    private GameObject playerObject;
    private CubeManager player;

    [SetUp]
    public void SetUp()
    {
        // Her testten önce çalışacak kod
        playerObject = new GameObject();
        player = playerObject.AddComponent<CubeManager>();
    }

    [Test]
    public void TakeDamage_ShouldReduceHealth()
    {
        player.TakeDamage(20);
        Assert.AreEqual(80, player.health);
    }

    [Test]
    public void AddScore_ShouldIncreaseScore()
    {
        player.AddScore(10);
        Assert.AreEqual(10, player.score);
    }

    [Test]
    public void TakeDamage_ShouldNotAllowNegativeHealth()
    {
        player.TakeDamage(200);
        Assert.AreEqual(0, player.health);
    }
}
