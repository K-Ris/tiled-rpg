using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerationTest : MonoBehaviour
{
    TerrainPrefabs prefabs;

    // Start is called before the first frame update
    void Start()
    {
        prefabs = this.GetComponent<TerrainPrefabs>();

        for (int i = -3; i < 4; i++)
        {
            for (int j = -3; j < 4; j++)
            {
                Debug.Log("i: " + i + " j: " + j);

                if(i == 0 && j == 0)
                {
                    Instantiate(prefabs.main_tile, new Vector3(0, 0, 0), Quaternion.identity);
                }
                else
                {
                    Instantiate(prefabs.tree_tile, new Vector3(i, 0, j), Quaternion.identity);
                }
            }
        }

        // for(int i = -1; i > -5; i--){
        //     for(int j = 0; j > -5; j--){
        //         Instantiate(prefabs.tree_tile, new Vector3(i, 0, j), Quaternion.identity);
        //     }
        // }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
