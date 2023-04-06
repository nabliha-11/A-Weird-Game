using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Drag : changeScene
{
 [SerializeField]
   private Canvas canvas;
public bool flag=false;
  public bool success=false;
  public GameObject Mug; 
   public void DragHandler(BaseEventData data)
   {
    PointerEventData pointerData=(PointerEventData)data;

    Vector2 position;
    RectTransformUtility.ScreenPointToLocalPointInRectangle(
        (RectTransform)canvas.transform, pointerData.position, 
        canvas.worldCamera, out position);

    transform.position=canvas.transform.TransformPoint(position);
    flag=true;
   }

public void OnMouseUp()
{
  if(Input.GetMouseButtonUp(0))
  {
    if(flag==true)
    {
      Debug.Log("yes");
      success=true;
      
      Mug.GetComponent<Image>().color = Color.red;
    }
    else{
      Debug.Log("no");
    }
  }
}
public void click()
{
   Debug.Log("clicked");
   SceneManager.LoadScene(3);
}
}
