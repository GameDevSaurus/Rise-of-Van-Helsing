using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level25 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        //CurrentSceneManager.sniper = true;
        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1.75f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 2f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(5, ActionTypes.Move));
        _levelActions.Add(new LevelAction(5, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(5, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(5, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(5, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(5, 4f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(10, ActionTypes.Move));
        _levelActions.Add(new LevelAction(10, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 10f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 11f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(16, ActionTypes.Move));
        _levelActions.Add(new LevelAction(16, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 3f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(24, ActionTypes.End));
    }

}
