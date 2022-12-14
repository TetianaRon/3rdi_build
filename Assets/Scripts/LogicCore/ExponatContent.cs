using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.LogicCore
{
    // [CreateAssetMenu(fileName = "ExponentContent", menuName = "3rdi/ExponentCont", order = 1)]
   
    public class ExponatContent : MonoBehaviour 
    {
        public bool IsFavorite=false;
        public string Name;
        public Texture2D Icons;
        [TextArea]
        public string Description;
        public UnityAction ObjectAction;
        public Texture2D[] Images;
        public AudioClip[] Tracks;
        public GameObject Prefab;
        public ExponatContent[] RefContent;

        public QuizQuestion Questions;

    }
}

