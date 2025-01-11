using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum logic_choice{
    or,
    and,
    not,
    xor,
    nand,
    nor,
    
}

public class logic_circuit : logic_state
{

    public Sprite on_sprite;
    public Sprite off_sprite;

    public logic_choice logic;
    // Start is called before the first frame update
    void Start()
    {
        
        logic_action();
        if(state){
            this.GetComponent<SpriteRenderer>().sprite = on_sprite;
        }
        else{
            this.GetComponent<SpriteRenderer>().sprite = off_sprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        logic_action();
        if(state){
            this.GetComponent<SpriteRenderer>().sprite = on_sprite;
        }
        else{
            this.GetComponent<SpriteRenderer>().sprite = off_sprite;
        }

    }


    delegate bool bool_logic(bool a,bool b);

    static bool andgate(bool a,bool b){
        return (a&&b);
    }

    static bool orgate(bool a,bool b){
        return (a||b);
    }
    static bool nandgate(bool a,bool b){
        return !(a&&b);
    }

    static bool norgate(bool a,bool b){
        return !(a||b);
    }

    static bool xorgate(bool a,bool b){
        return (a^b);
    }

    static bool logic_gate(GameObject [] input,bool_logic bl){
        bool temp = input[0].GetComponent<logic_state>().state;
        for(int i = 0;i < input.Length-1; i++){
            temp = bl(temp,
            input[i+1].GetComponent<logic_state>().state);
        }
        return temp;
    }
    public void logic_action(){
        if(input_logic.Length == 1){
            if(logic == logic_choice.not){
                state = !input_logic[0].GetComponent<logic_state>().state;
            }
            else{
                state = input_logic[0].GetComponent<logic_state>().state;
            }
        }
        else if(input_logic.Length > 1){
            Debug.Log("len2");
            switch(logic){
            case logic_choice.and:
                state = logic_gate(input_logic,new bool_logic(andgate));
            break;
            case logic_choice.or:
                state = logic_gate(input_logic,new bool_logic(orgate));
            break;
            case logic_choice.not:
            //이건 안되게 해놓자 나중에
            break;
            case logic_choice.xor:
                state = logic_gate(input_logic,new bool_logic(xorgate));
            break;
            case logic_choice.nand:
                state = logic_gate(input_logic,new bool_logic(nandgate));
            break;
            case logic_choice.nor:
                state = logic_gate(input_logic,new bool_logic(norgate));
            break;
            }
        }
        
    }
}
