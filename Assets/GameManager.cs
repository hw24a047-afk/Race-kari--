using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    private void Awake()
    {
        instance = this;
    }



public  void Test()
    {
        Debug .Log("staticの解説中");
    }

}