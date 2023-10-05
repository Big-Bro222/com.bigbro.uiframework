using UnityEngine;

namespace BigBro.UIframework
{
    [RequireComponent(typeof(Canvas))]
    public class UIPanelRegister : MonoBehaviour
    {
        void Awake()
        {
           UIManager.Instance.SetParentCanvas(GetComponent<Canvas>());
        }

    }
}
