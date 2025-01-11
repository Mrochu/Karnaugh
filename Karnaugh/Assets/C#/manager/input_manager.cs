using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class input_manager : singleton_patten<input_manager>
{
    
    public camera_raycast temp_cam_ray;
    // Start is called before the first frame update
    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            GameObject temp_obj = temp_cam_ray.cam_ray_hit();
            //temp_cam_ray.cam_ray_hit();
            if(temp_obj == null){return; }
            if(temp_obj.tag == "button"){
                temp_obj.GetComponent<click_button>().click();
                Debug.Log("button_click");
            }
        }
    }
}
