using System;
using UnityEngine;
using System.Collections.Generic;

namespace BigBro.UIframework
{
    public class UIManager : MonoBehaviour
    {
        public Canvas UIPanelCanvas { get; private set; }
        private static UIManager _uiManagerInstance;
        public static UIManager Instance => _uiManagerInstance;
        private Dictionary<string, UIPanelBase> panelsDic = new Dictionary<string, UIPanelBase>();

        void Awake()
        {
            //There should be only one UIManager
            DontDestroyOnLoad(this);
            if (_uiManagerInstance == null)
            {
                _uiManagerInstance = this;
            }
            else
            {
                DestroyObject(gameObject);
            }
        }

        private void Update()
        {
            //Debug.Log("UiStack count: "+ _uiStack.Count);
        }

        public void SetParentCanvas(Canvas rootCanvas)
        {
            UIPanelCanvas = rootCanvas;
            RegisterPanels();
        }

        // Close All the panels
        public void CloseAll()
        {
            while (_uiStack.Count != 0)
            {
                PopPanel();
            }
        }

        // Close a certain amount of layers of panel
        public void ClosePanelsOnTop(int panelCount)
        {
            while (panelCount > 0)
            {
                PopPanel();
            }
        }

        // Return Panel
        public T FindPanel<T>() where T : UIPanelBase
        {
            return null;
        }


        private Stack<UIPanelBase> _uiStack = new Stack<UIPanelBase>();


        public UIPanelBase OpenPanel(string panelName, Action<UIPanelBase> setup = null)
        {
            UIPanelBase panel = PushPanel(panelName);
            //This setup is used for inject refs will the panel is opened
            setup?.Invoke(panel);
            return PushPanel(panelName);
        }

        public void CloseCurrentPanel()
        {
            PopPanel();
        }

        private void RegisterPanels()
        {
            UIPanelBase[] uiPanelBases = UIPanelCanvas.transform.GetComponentsInChildren<UIPanelBase>();
            foreach (var uiPanelBase in uiPanelBases)
            {
                panelsDic.Add(uiPanelBase.name, uiPanelBase);
            }
        }

        private UIPanelBase GetPanel(string panelName)
        {
            return panelsDic[panelName];
        }

        private void PopPanel()
        {
            if (_uiStack.Count <= 0)
            {
                return;
            }

            //close current panel
            UIPanelBase topPanel = _uiStack.Pop();
            topPanel.Close();

            //resume the previous one
            if (_uiStack.Count > 0)
            {
                UIPanelBase panel = _uiStack.Peek();
                panel.Resume();
            }
        }

        private UIPanelBase PushPanel(string panelName)
        {
            //Pause the previous menu
            if (_uiStack.Count > 0)
            {
                UIPanelBase topPanel = _uiStack.Peek();
                topPanel.Pause();
            }

            UIPanelBase panel = GetPanel(panelName);
            _uiStack.Push(panel);
            panel.Open();
            return panel;
        }
    }
}