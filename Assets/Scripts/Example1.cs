using UnityEngine;
using System.Collections;

public class Example1 : MonoBehaviour {

    public GameObject[] gos;

	// Use this for initialization
	void Start () {
        gos = new GameObject[10];

        for(int i = 0; i < 10; i++)
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);

            Vector3 v = new Vector3();
            v.x = Random.Range(-10, 10);
            v.z = Random.Range(-10, 10);

            go.transform.position = v;
            go.name = i.ToString();

            if (i%2 == 0)
            {
                go.AddComponent(typeof(ZombieData));
            }

            gos[i] = go;
        }
	}
	
	// Update is called once per frame
	void Update () {
	    foreach(GameObject go in gos)
        {
            ZombieData zd = (ZombieData)go.GetComponent(typeof(ZombieData));
            
            if(zd == null)
            {
                continue;
            }
            if(zd.hitpoints > 0)
            {
                break;
            }

            print(go.name);
            zd.hitpoints = 10;
        }
	}
}
