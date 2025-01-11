using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_raycast : MonoBehaviour
{

    Camera cam_ray;
    // Start is called before the first frame update
    void Awake()
    {
        cam_ray = Camera.main;
        //cam_ray_hit();
    }

    public GameObject cam_ray_hit(float MaxDist = 20f){
            Vector3 MousePosition = Input.mousePosition;
            MousePosition = cam_ray.ScreenToWorldPoint(MousePosition);

            RaycastHit2D hit = Physics2D.Raycast(MousePosition,transform.forward,MaxDist);
            Debug.DrawLine(MousePosition,transform.forward,Color.red,10f);
            if(hit){
                //OnTouchTile.AddListener(test);
                Debug.Log("hit");
                return hit.transform.gameObject;
                
                //
            }
        Debug.Log("not_hit");
        return null;
    }

}
