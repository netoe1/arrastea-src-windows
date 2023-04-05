using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ConfiguraCursor : MonoBehaviour
{

    public static ConfiguraCursor instance;
    public Texture2D cursor;
    public Texture2D cursorClick;
    public Texture2D cursorDrag;


    void Awake()
    {
        instance = this;
        ConfiguraCursor.instance.ActiveCursor();
        
    }


    public void ActiveCursorClick()
    {
        Cursor.SetCursor(cursorClick, Vector2.zero, CursorMode.Auto);
    }

    public  void ActiveCursorDrag()
    {
        Cursor.SetCursor(cursorDrag, Vector2.zero, CursorMode.Auto);
    }

    public void ActiveCursor()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

}