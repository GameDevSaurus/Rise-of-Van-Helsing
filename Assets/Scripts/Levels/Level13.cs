using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level13 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        //CurrentSceneManager.sniper = true;
        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0,0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 3f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(5, ActionTypes.Move));
        _levelActions.Add(new LevelAction(5, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(5, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(5, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(5, 4f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(9, ActionTypes.Move));
        _levelActions.Add(new LevelAction(9, 2.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 10f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 11f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(16, ActionTypes.Move));

        _levelActions.Add(new LevelAction(16, 2.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 9.5f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(21, ActionTypes.End));
    }

}
