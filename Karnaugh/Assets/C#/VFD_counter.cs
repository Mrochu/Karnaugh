using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFD_counter : MonoBehaviour
{
    public GameObject VFD0;
    public GameObject VFD00;
    public Sprite[] VFD_count;
    // Start is called before the first frame update
    public int count;
    public int max_scene;
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        VFD00.GetComponent<SpriteRenderer>().sprite = VFD_count[count/10];
        VFD0.GetComponent<SpriteRenderer>().sprite = VFD_count[count%10];
    }

    public void VFD_00_up(){
        if(max_scene > count + 10){
            count = count + 10;
        }
    }
    public void VFD_00_down(){
        if(0 < count - 10){
            count = count - 10;
        }
    }
    public void VFD_0_up(){
        if(max_scene > count + 1){
            count = count + 1;
        }
    }
    public void VFD_0_down(){
        if(0 < count - 1){
            count = count - 1;
        }
    }

}
