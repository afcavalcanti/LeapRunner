using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObstacleGenerator : MonoBehaviour {

    public GameObject obstaculo;
	public static float nObstaculos = 200;

	// Use this for initialization
	void Start () {

        for (int i = 0; i < nObstaculos; i++)
        {
            //faz n copias dentro do intervalo definido na funcao random
            Instantiate(obstaculo, new Vector3(Random.Range(10f, 198f), 0.5f, Random.Range(7f, -7f)), Quaternion.identity); 
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
