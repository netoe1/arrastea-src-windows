using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ConfiguraCursor : MonoBehaviour
{
   public static void set_cursor(string __path)
   {
        PlayerSettings.defaultCursor = Resources.Load<Texture2D>(__path);
        Debug.Log("Set cursor");
   }
}
