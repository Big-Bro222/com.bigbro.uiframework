using UnityEngine;

namespace BigBro.Core
{
    public class GetUnityVersion : MonoBehaviour
    {
        public static void LogInfo()
        {
            Debug.Log("Unity version "+ Application.unityVersion);
            Debug.Log("Platform " + Application.platform);
        }
    }
}
