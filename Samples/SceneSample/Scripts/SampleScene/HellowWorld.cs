using BigBro.Core;
using UnityEngine;

namespace BigBro.SampleScene
{
    public class HellowWorld : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Add sample scene success!");
            GetUnityVersion.LogInfo();
        }
    }
}
