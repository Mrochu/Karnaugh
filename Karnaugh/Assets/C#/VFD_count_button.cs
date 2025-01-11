using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum VFD_button_enum{
    VFD00up,
    VFD00down,
    VFD0up,
    VFD0down,
    VFDscene_change,
}
public class VFD_count_button : MonoBehaviour
{

    public VFD_button_enum Vbe;
    public GameObject VFD;

    private VFD_counter VFD_count_temp;

     public Sprite on_sprite;
    public Sprite off_sprite;

    // Start is called before the first frame update
    void Start()
    {
        VFD_count_temp = VFD.GetComponent<VFD_counter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator button_click()
    {
        
	    yield return new WaitForSecondsRealtime( 0.3f );
        this.GetComponent<SpriteRenderer>().sprite = on_sprite;
    // 함수 내용
    }

    public void click(){
        this.GetComponent<SpriteRenderer>().sprite = off_sprite;
        switch(Vbe){
            case VFD_button_enum.VFD00up:
                VFD_count_temp.VFD_00_up();
            break;
            case VFD_button_enum.VFD00down:
                VFD_count_temp.VFD_00_down();
            break;
            case VFD_button_enum.VFD0up:
                VFD_count_temp.VFD_0_up();
            break;
            case VFD_button_enum.VFD0down:
                VFD_count_temp.VFD_0_down();
            break;
            case VFD_button_enum.VFDscene_change:
                //VFD.GetComponent<VFD_counter>().VFD_0_down();
                scene_man.Instance.change_game_scene(VFD_count_temp.count);
            break;
            }
        StartCoroutine(button_click());
    }
}
