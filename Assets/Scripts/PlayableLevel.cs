using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayableLevel : MonoBehaviour
{
    public List<EnemyController> _enemyControllers;
    public List<TimedAction> _timedActions;
    public List<LevelAction> _levelActions;
    public enum ActionTypes {Move,AddEnemy,End}
    public abstract void Initialize();
    int _enemyCounter;
    int _moveCounter;
    bool _canStart;
    PlayerController _playerController;
    public void SetPlayerController(PlayerController newPlayerController)
    {
        _playerController = newPlayerController;
    }
    private void Update()
    {
        if (_canStart)
        {
            for (int i = 0; i < _timedActions.Count; i++)
            {
                if (CurrentSceneController._elapsedGameTime >= _timedActions[i]._timeToTrigger)
                {
                    ExecuteAction(_timedActions[i]._action);
                    _timedActions.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < _levelActions.Count; i++)
            {
                if (CurrentSceneController._kills >= _levelActions[i]._killsToTrigger)
                {
                    if (_levelActions[i]._delay != 0)
                    {
                        float futureTime = CurrentSceneController._elapsedGameTime + _levelActions[i]._delay;
                        _timedActions.Add(new TimedAction(futureTime, _levelActions[i]._action));
                    }
                    else
                    {
                        ExecuteAction(_levelActions[i]._action);
                    }
                    _levelActions.RemoveAt(i);
                    i--;

                }
            }
        }       
    }



    public void ExecuteAction(ActionTypes action)
    {
        switch (action)
        {
            case ActionTypes.AddEnemy:

                if (!_enemyControllers[_enemyCounter].gameObject.activeSelf)
                {
                    _enemyControllers[_enemyCounter].gameObject.SetActive(true);
                }
                _enemyControllers[_enemyCounter].Init();
                _enemyCounter++;
                break;
            case ActionTypes.End:
                GameEvents.LoadScene.Invoke("Configuration");
                break;

            case ActionTypes.Move:
                _playerController.Move(_moveCounter);
                _moveCounter++;
                break;

        }
        
    }
    private void Awake()
    {
        GameEvents.StartLevel.AddListener(CanStart);
    }
    public void CanStart()
    {
        _canStart = true;
    }
    public void Init()
    {
        _timedActions = new List<TimedAction>();
        _levelActions = new List<LevelAction>();
    }
    public class TimedAction
    {
        public float _timeToTrigger;
        public ActionTypes _action;

        public TimedAction(float timeToTrigger, ActionTypes action)
        {
            _timeToTrigger = timeToTrigger;
            _action = action;
        }
    }
    public class LevelAction
    {
        public int _killsToTrigger;
        public ActionTypes _action;
        public float _delay;
        public LevelAction(int killsToTrigger, ActionTypes action)
        {
            _killsToTrigger = killsToTrigger;
            _action = action;
            _delay = 0;
        }
        public LevelAction(int killsToTrigger,float delay, ActionTypes action)
        {
            _killsToTrigger = killsToTrigger;
            _action = action;
            _delay = delay;
        }
    }
}
