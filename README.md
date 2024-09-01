# Testing in Unity

## Overview

This project demonstrates unit testing in Unity using the NUnit framework. It includes tests for a simple `CubeManager` class that manages a player's health and score. The purpose of this project is to provide a clear example of how to write and organize unit tests for Unity components.

## Setup

1. **Unity Version**: Make sure you are using Unity 2021.3 or later.
2. **NUnit Framework**: Ensure you have NUnit installed in your Unity project. You can install it via the Unity Package Manager by adding the NUnit package.

## Project Structure

- **Scripts**
  - `CubeManager.cs`: The main script that contains the `CubeManager` class which manages the player's health and score.
  - `PlayerTests.cs`: Unit tests for the `CubeManager` class using NUnit.

## Scripts

### `CubeManager.cs`

```csharp
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public int health = 100;
    public int score = 0;

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health < 0) health = 0;
    }

    public void AddScore(int amount)
    {
        score += amount;
    }
}
```

### `PlayerTests.cs`
```csharp
using NUnit.Framework;
using UnityEngine;

public class PlayerTests
{
    private GameObject playerObject;
    private CubeManager player;

    [SetUp]
    public void SetUp()
    {
        // Code to run before each test
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
```

### `CubeManager.cs`
```csharp
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
```

### Running Tests
Open Unity and load the project.
Go to Window -> General -> Test Runner.
In the Test Runner window, select PlayMode or EditMode depending on where your tests are located.
Click the Run All button to execute all tests.
