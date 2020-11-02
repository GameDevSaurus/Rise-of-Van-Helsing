using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level32 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        //CurrentSceneManager.sniper = true;
        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 2.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 3.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 8.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 9.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 10.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 11.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 15.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 16.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 17.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 18.3f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(12, ActionTypes.Move));
        _levelActions.Add(new LevelAction(12, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 0.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 0.4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 0.5f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(20, ActionTypes.Move));
        _levelActions.Add(new LevelAction(20, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 2.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 2.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 4.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 6.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 7.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 8.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 10.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 11.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 13.1f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(30, ActionTypes.Move));
        _levelActions.Add(new LevelAction(30, 1.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(30, 2.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(30, 3.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(30, 4.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(30, 5.6f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(35, ActionTypes.End));
    }

}
