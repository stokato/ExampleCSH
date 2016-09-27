using UnityEngine;
using System.Collections;

public class ZombieSpawner : MonoBehaviour
{

    private int dtTimeout = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dtTimeout++;

        if(Zombie.numZombies < 4 && dtTimeout > 50)
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            go.AddComponent(typeof(Zombie));
            go.transform.position = transform.position;

            dtTimeout = 0;
        }
    }
}
