using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform startPoint;
    //Enemy path that they take (The orange points in the game)
    public Transform[] path;

    private void Awake()
    {
        main = this;
    }
}
