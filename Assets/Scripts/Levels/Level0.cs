using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level0 : PlayableLevel
{
    public override void Initialize()
    {
        base.Init();
        _levelActions.Add(new LevelAction(0,ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(1,2, ActionTypes.Move));
        _levelActions.Add(new LevelAction(1,2, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(1, 2, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, 2, ActionTypes.Move));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 2, ActionTypes.Move));
        _levelActions.Add(new LevelAction(6, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, ActionTypes.End));

    }
}
