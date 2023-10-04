using UnityEditor;
using UnityEngine;

namespace BigBro.Editor
{
    public class HelloWorldEditor : MonoBehaviour
    {
        [MenuItem(("Assets/Print Editor Message"))]
        static void PrintEditorMsg(){
            Debug.Log("Editor example log");
        }
    }
}
