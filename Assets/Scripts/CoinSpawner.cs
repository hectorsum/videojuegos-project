using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    float timer;
    public GameObject PrefabCoin;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 2f)
        {
            timer = 0;
            float x = Random.Range(0, 50);
            Vector3 position = new Vector3(x,20,0);
            Quaternion rotation = new Quaternion();
            Instantiate(PrefabCoin, position, rotation);
        }
    }
}
