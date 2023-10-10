using UnityEngine;
using System;

namespace BigBro.UIframework
{
    [RequireComponent(typeof(RectTransform)), DisallowMultipleComponent]
    public abstract class UIPanelBase : MonoBehaviour
    {
        public bool ShouldOpenAtBegin = false;
        protected bool created = false;
        protected UIState state = UIState.None;

        public UIState State => state;

        public event Action OnClosePanelEvent;
        public event Action OnOpenPanelEvent;


        internal virtual void Open()
        {
            gameObject.SetActive(true);
            state = UIState.Open;
            transform.SetAsLastSibling();
            OnOpen();
            OnOpenPanelEvent?.Invoke();
        }

        internal virtual void Close()
        {
            gameObject.SetActive(false);
            state = UIState.Close;
            OnClose();
            OnClosePanelEvent?.Invoke();
        }

        public virtual void Pause()
        {
            state = UIState.Paused;
            OnPause();
        }

        public virtual void Resume()
        {
            state = UIState.Close;
            //transform.SetAsLastSibling();
            OnResume();
        }
        

        private void Awake()
        {
            OnCreate();
            created = true;
            state = UIState.Init;
        }

        private void Start()
        {
            Debug.Log("RunStart");
            if (!ShouldOpenAtBegin)
            {
                gameObject.SetActive(false);
            }
            else
            {
                Debug.Log("Open "+ name);
                UIManager.Instance.OpenPanel(name);
            }
        }

        private void OnDestroy()
        {
            OnRelease();
        }

        private void Update()
        {
            OnUpdate();
        }


        #region Protected Life circle

        protected virtual void OnCreate()
        {
        }

        protected virtual void OnOpen()
        {
        }

        protected virtual void OnPause()
        {
        }

        protected virtual void OnResume()
        {
        }

        protected virtual void OnUpdate()
        {
        }

        protected virtual void OnClose()
        {
        }

        protected virtual void OnRelease()
        {
        }

        #endregion

        public enum UIState
        {
            None,
            Open,
            Close,
            Paused,
            Init
        }
    }
}