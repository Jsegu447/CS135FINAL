using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject prefab = Resources.Load ("brick") as GameObject;
        for (int i = 0; i < 5;i++){
            for(int height = 0; height < 10; height++){
                GameObject brick = Instantiate(prefab) as GameObject;
                brick.transform.position = new Vector3(prefab.transform.position.x+(i*0.2f),
                prefab.transform.position.y+height*0.1f,
                prefab.transform.position.z);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
