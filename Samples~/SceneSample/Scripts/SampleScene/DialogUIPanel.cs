using UnityEngine.UI;
using UnityEngine;

namespace BigBro.UIframework
{
    public class DialogUIPanel : UIPanelBase
    {
        
        [SerializeField] private Button confirmBtn;
        [SerializeField] private Button cancelBtn;
        
        protected override void OnOpen()
        {
            base.OnOpen();
            confirmBtn.onClick.AddListener(Confirm);
            cancelBtn.onClick.AddListener(Cancel);
        }

        protected override void OnClose()
        {
            base.OnClose();
            confirmBtn.onClick.RemoveListener(Confirm);
            cancelBtn.onClick.RemoveListener(Cancel);
        }
        
        private void Confirm()
        {
            UIManager.Instance.CloseCurrentPanel();
            Debug.Log("Dialog confirmed!");
        }

        private void Cancel()
        {
            UIManager.Instance.CloseCurrentPanel();
            Debug.Log("Dialog canceled!");
        }

    }
}
