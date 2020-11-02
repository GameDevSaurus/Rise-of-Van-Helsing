using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level9 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        //CurrentSceneManager.sniper = true;
        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0,2, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0,2, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 2, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 2, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(4, ActionTypes.Move));
        _levelActions.Add(new LevelAction(4, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(4, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(4, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(4, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 2, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 2, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 4, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 5, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 6, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(14, ActionTypes.End));
    }

}
