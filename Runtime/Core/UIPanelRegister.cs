using System;
using UnityEngine;

namespace BigBro.UIframework
{
    [RequireComponent(typeof(Canvas))]
    public class UIPanelRegister : MonoBehaviour
    {
        void Awake()
        {
           UIManager.Instance?.SetParentCanvas(GetComponent<Canvas>());
        }

        private void OnDestroy()
        {
            //when switch scene, unregister the UIPanels
            UIManager.Instance?.CloseAll();
        }
    }
}
