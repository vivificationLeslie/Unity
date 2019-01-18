using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateInstance : MonoBehaviour {

    public GameObject prefab01; //prefab01预设体
    public GameObject sphere; //sphere预设体
    private Vector3 pos; //实例化的位置

	// Use this for initialization
	void Start () {
        //初始化实例的位置
        pos = new Vector3(0, 8, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A)) //键盘输入A
        {
            //实例化Prefab01
            Instantiate(prefab01, pos, Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //实例化Sphere
            Instantiate(sphere, pos, Quaternion.identity);
        }
	}
}
