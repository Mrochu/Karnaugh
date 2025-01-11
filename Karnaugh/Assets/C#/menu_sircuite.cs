using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_sircuite : MonoBehaviour
{
    public GameObject[] temp;
    public float per;
    public float wid;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < temp.Length; i++){
            temp[i].transform.position = new Vector3(per * i + wid,temp[i].transform.position.y,temp[i].transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
