using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveThings : MonoBehaviour
{
    public GameObject correctForm;
    private bool moving;

private float startPosX;
private float startPosY;

    void Start()
    {

    }

    void Update()
    {
      if(moving)
      {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        this.gameObject.transform.localPosition=new Vector3(mousePos.x - startPosX,mousePos.y - startPosY,this.gameObject.transform.localPosition.z);
      }
    }

    public void OnMouseClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
          Vector3 mousePos;
          mousePos = Input.mousePosition;
          mousePos = Camera.main.ScreenToWorldPoint(mousePos);

          startPosX = mousePos.x - this.transform.localPosition.x;
          startPosY = mousePos.y - this.transform.localPosition.y;

          moving =true;
        }
    }

    public void OnMouseUp()
    {
      moving=false;
    }
}
