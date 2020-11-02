using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : PlayableLevel
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
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, ActionTypes.Move));
        _levelActions.Add(new LevelAction(6, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, ActionTypes.Move));
        _levelActions.Add(new LevelAction(9, ActionTypes.End));
        //done
    }

}
