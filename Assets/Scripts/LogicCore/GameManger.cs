using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.LogicCore
{
    public class GameManger:MonoBehaviour
    {
        private void Awake()
        {
            var exponants = FindObjectsOfType<InteractableExponat>();
            _interactableManger = new InteractableManger(exponants);

            _interactableManger.OnNewExponatActivated += (e) =>
            {
               // _panelManger.ContentUpdate(e);
            };


        }
         private InteractableManger _interactableManger;
        [SerializeField]
        private PanelManger _panelManger; 


    }


    [Serializable]
    public class InteractableManger
    {
        private static InteractableManger _instance; 
        public List<InteractableExponat> InteractableObjects;
        public event Action<ExponatContent> OnNewExponatActivated;

        public InteractableManger(InteractableExponat[] interactableObjects)
        {
            InteractableObjects = interactableObjects.ToList();
            Debug.Log($"Interactbale Manger: we found {InteractableObjects.Count} in scene");

        }

        public static void Register(InteractableExponat interactableExponat)
        {

            if (_instance==null)
                throw new Exception("Instance of Interactable Manger isn't created");
            _instance.RegisterObject(interactableExponat);

            _instance.InteractableObjects.Add(interactableExponat);
        }

        private void RegisterObject(InteractableExponat interactableExponat)
        {
            if (InteractableObjects.Contains(interactableExponat))
         
                Debug.Log($"We already contain {interactableExponat.name}");

            else
            {
                InteractableObjects.Add(interactableExponat);
                Debug.Log($"We  add exponant {interactableExponat.name}");
            }


        }

    }
}