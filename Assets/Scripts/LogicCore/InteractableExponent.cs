using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.LogicCore
{
    public class InteractableExponat : MonoBehaviour
    {
        public event Action<InteractableExponat> OnFocus;
        public event Action<ExponentContent> OnPressed;

        [SerializeField]
        private UnityAction OnActionAction;

        [SerializeField]
        private ExponentContent _content;

        public void DoAction()
        {
         OnActionAction?.Invoke();
        }



    }
}