using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    GameModel _gameModel;
    GameView _gameView;

    private void Awake()
    {
        _gameModel = GetComponent<GameModel>();
        _gameView = GetComponent<GameView>();
    }
    void Start()
    {
        _gameModel.randomizedNumber = Random.Range(1, 4);
        _gameView.InstancePrefab();
    }
}
