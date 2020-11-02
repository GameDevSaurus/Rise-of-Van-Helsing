using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        _levelActions.Add(new LevelAction(0, 0.5f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0,4,ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 4, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(2, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(2, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(2, ActionTypes.Move));
        _levelActions.Add(new LevelAction(4, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(4, ActionTypes.Move));
        _levelActions.Add(new LevelAction(5, ActionTypes.End));
    }

}
