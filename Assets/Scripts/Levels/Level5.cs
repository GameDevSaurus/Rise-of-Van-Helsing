using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        //CurrentSceneManager.sniper = true;
        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(4, ActionTypes.Move));
        _levelActions.Add(new LevelAction(4, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(4, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(4, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(4, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(4, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, ActionTypes.Move));
        _levelActions.Add(new LevelAction(9, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, ActionTypes.End));
    }

}
