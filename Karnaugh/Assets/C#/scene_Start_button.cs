using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene_Start_button : logic_state
{
    
    public Sprite on_sprite;
    public Sprite off_sprite;

    public GameObject logo;
    Animator logoani;
    // Start is called before the first frame update
    void Start()
    {
        logoani = logo.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(state){
            this.GetComponent<SpriteRenderer>().sprite = on_sprite;
        }
        else{
            this.GetComponent<SpriteRenderer>().sprite = off_sprite;
        }
    }

    public void click(){
        //추후에 에니메이션 방식으로 전환예정
        //지금은 그냥 스프라이트 변경 방식 단순한 프로토 타입이기에 사용하는것임을 명심 추후에 코드 대체할것
        logoani.SetTrigger("logo_start");
        state = !state;
        if(state){
            this.GetComponent<SpriteRenderer>().sprite = on_sprite;
        }
        else{
            this.GetComponent<SpriteRenderer>().sprite = off_sprite;
        }
        
    }
}
