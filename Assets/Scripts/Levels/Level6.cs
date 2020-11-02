using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level6 : PlayableLevel
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
        _levelActions.Add(new LevelAction(3, ActionTypes.Move));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6,1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6,2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 2.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 3.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, ActionTypes.End));
        //done
    }

}
