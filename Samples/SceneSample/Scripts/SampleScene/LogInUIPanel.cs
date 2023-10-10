using UnityEngine;
using UnityEngine.UI;

namespace BigBro.UIframework
{
    public class LogInUIPanel : UIPanelBase
    {
        [SerializeField] private Button _loginBtn;
        

        protected override void OnCreate()
        {
            base.OnCreate();
        }

        protected override void OnOpen()
        {
            base.OnOpen();
            _loginBtn.onClick.AddListener(Login);
        }

        protected override void OnClose()
        {
            base.OnClose();
            _loginBtn.onClick.RemoveListener(Login);
        }

        private void Login()
        {
            UIManager.Instance.OpenPanel("DialogUIPanel",null);
        }
    }
}