using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts
{
    [CreateAssetMenu]
    public class GameSetup : ScriptableObject
    {
        public int GameBoardSizeX;
        public int GameBoardSizeY;

        public GameObject EmptyCell;

        public float BoardXStartPoint;
        public float BoardYStartPoint;
        
        public GameObject[] Artifacts;
    }
}