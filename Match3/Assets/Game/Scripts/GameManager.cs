using System.Collections;
using UnityEngine;

namespace Game.Scripts
{
    public class GameManager : MonoBehaviour
    {
        
        public GameSetup GameSetup;
        public Transform Board;

        private GameObject[,] _board;

        private void Start()
        {
            int x = GameSetup.GameBoardSizeX;
            int y = GameSetup.GameBoardSizeY;
         
            _board = new GameObject[x, y];
            
            BuildBoard(x, y);
            FillTheBoard();
        }

        private void BuildBoard(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    float posX = j + GameSetup.BoardXStartPoint;
                    float posY = i + GameSetup.BoardYStartPoint;
                    
                    GameObject emptyCell = Instantiate(GameSetup.EmptyCell);
                    emptyCell.transform.position = new Vector2(posX, posY);
                    emptyCell.transform.SetParent(Board);
                    _board[i, j] = emptyCell;
                }
            }
        }

        private void FillTheBoard()
        {
            for (int i = 0; i < GameSetup.GameBoardSizeX; i++)
            {
                for (int j = 0; j < GameSetup.GameBoardSizeY; j++)
                {
                    int randomArtifactIndex = Random.Range(0, GameSetup.Artifacts.Length);
                    GameObject targetArtifact = GameSetup.Artifacts[randomArtifactIndex];
                    GameObject artifact = Instantiate(targetArtifact);
                    artifact.transform.SetParent(_board[i, j].transform);
                    artifact.transform.localPosition = Vector3.zero;
                }
            }
        }
    }
}