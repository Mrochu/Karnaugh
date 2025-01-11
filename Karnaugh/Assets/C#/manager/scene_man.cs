using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_man : singleton_patten<scene_man>
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void menu_scene_clip(){
        SceneManager.LoadScene("Menu_scene");
    }

}