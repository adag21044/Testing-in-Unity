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
