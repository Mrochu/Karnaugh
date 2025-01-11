using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circit_lin : MonoBehaviour
{
    LineRenderer temp;

    GameObject output;
    GameObject input;

    public float lin_per = 2;

    // Start is called before the first frame update
    void Start()
    {
        temp = this.GetComponent<LineRenderer>();
        temp.positionCount = this.GetComponent<logic_state>().input_logic.Length * 6 + 1;
        for(int i = 0; i < this.transform.childCount;i++){
            if(this.transform.GetChild(i).name == "input"){
                input = this.transform.GetChild(i).gameObject;
            }
            else if(this.transform.GetChild(i).name == "output"){
                output = this.transform.GetChild(i).gameObject;
            }
        }

        if(temp != null && input != null && output != null){
            if(this.GetComponent<logic_state>().input_logic.Length >= 1)
            {
            //Debug.Log("linelender");
            temp.SetPosition(0,input.transform.position);
            int line_num = 1;
            for(int i = 0;i < this.GetComponent<logic_state>().input_logic.Length; i++){
                float harf_x = (input.transform.position.x + 
                this.GetComponent<logic_state>().input_logic[i].transform.GetChild(1).position.x)/lin_per;

                float harf_y = (input.transform.position.y + 
                this.GetComponent<logic_state>().input_logic[i].transform.GetChild(1).position.y)/2;
                
                Vector3 tempvec = new Vector3(input.transform.position.x,harf_y,0);
                Vector3 tempvec2 = new Vector3(this.GetComponent<logic_state>().input_logic[i].transform.GetChild(1).position.x,harf_y,0);
                temp.SetPosition(line_num,tempvec);
                line_num++;
                temp.SetPosition(line_num,tempvec2);
                line_num++;
                temp.SetPosition(line_num,this.GetComponent<logic_state>().input_logic[i].transform.GetChild(1).position);
                line_num++;
                temp.SetPosition(line_num,tempvec2);
                line_num++;
                temp.SetPosition(line_num,tempvec);
                line_num++;
                temp.SetPosition(line_num,input.transform.position);
                line_num++;
                //this.GetComponent<logic_state>().input_logic[i]
            }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
