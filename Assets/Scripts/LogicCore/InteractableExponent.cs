using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.LogicCore
{
    public class InteractableExponat : MonoBehaviour
    {
        public event Action<InteractableExponat> OnFocus;
        public event Action<ExponatContent> OnPressed;


        [SerializeField]
        private UnityAction OnActionAction;

        [SerializeField]
        private ExponatContent _content;

        public void DoAction()
        {
             OnActionAction?.Invoke();
        }



    }
}