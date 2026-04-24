using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Test : MonoBehaviour
{
List<int> numbers = new List<int>(){1,2,3,4};
public List<int> numbers2;
    void Start()
    {
numbers2[0] = 10;

numbers2.Add(100);

// numbers2.Clear();
// numbers2.RemoveAt(0);
numbers2.Remove (100);
    }

    void Update()
    {
        
    }
}
