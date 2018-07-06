using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour {

    GameModel _gameModel;
    private void Awake()
    {
        _gameModel = GetComponent<GameModel>();
    }

    public void InstancePrefab()
    {
        Instantiate(_gameModel.modulePrefab[_gameModel.randomizedNumber-1]);
    }
}
