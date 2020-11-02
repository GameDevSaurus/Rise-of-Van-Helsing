using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, ActionTypes.Move));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, ActionTypes.End));
        //done
    }

}
