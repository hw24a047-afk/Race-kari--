using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Test : MonoBehaviour
{
[SerializeField]
public int attack;

int hp = 100;
    void Start()
    {
    Damage (attack);

    GameManager.instance .Test ();
    }

    void Update()
    {
        
    }
    void Damage(int attackDamage)
    {
        hp -= attackDamage;
        // Debug.Log(hp);

        if (HPCheck())
        {
            Debug .Log (name + "はHPが50を切りました");
        }
        else
        {
            Debug .Log(name + "はHPに余裕があります");
        }
    }

    bool HPCheck()
    {
        if(hp <= 50)
        {
            return true;
        }
        return false;
    }
}
