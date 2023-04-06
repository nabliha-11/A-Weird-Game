using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public static bool flag;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        flag = true;
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(textComponent.text==lines[index])
            {
                NextLine();
            }
            else{
                StopAllCoroutines();
                textComponent.text=lines[index];
            }
        }
    }


    public void DialogTrigger()
    {
         if(Input.GetKeyDown(KeyCode.Space))
            {startDialogue();
               flag=true;}
    }
    void startDialogue()
    {
        index=0;
     
        StartCoroutine(Typeline());
    }
    IEnumerator Typeline()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text+=c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine(){
        if(index<lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(Typeline());
        }
        else{
            // gameObject.SetActive(false);
            flag=false;
        }
    }
}