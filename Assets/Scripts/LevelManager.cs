using UnityEngine;


public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform startPoint;
    //Enemy path that they take (The orange points in the game)
    public Transform[] path;

    public int currency;
    public int health;

    private void Awake()
    {
        main = this;
    }

    private void Start()
    {
        currency = 100;
        health = 100;
    }

    public void IncreaseCurrency(int amount)
    {
        currency += amount;
    }

    public bool SpendCurrency(int amount)
    {
        if (amount <= currency)
        {
            currency -= amount;
            return true;
        }
        else
        {
            //Debug.Log("Youre a brokee,");
            return false; //do nothing if the player is broke (can add a small ui to display it later)
        }
    }

    public void ChangeHealth(int amount)
    {
        health -= amount;
    }
}
