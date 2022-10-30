using System;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.LogicCore
{
   [CreateAssetMenu(fileName = "ExponentContent", menuName = "3rdi/ExponentCont", order = 1)]
    public class ExponentContent : ScriptableObject
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
        public ExponentContent[] RefContent;

        public QuizQuestion Questions;

    }
    

    [Serializable]
    public class QuizQuestion{

        public string Name;
        [TextArea]
        public string Description; 

        public string[] Options;
        [Tooltip("Indexing start with 0. If the first anser is right that put 0 here")]
        public int RightAnswer;

    }
}

