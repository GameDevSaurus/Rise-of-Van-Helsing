using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level14 : PlayableLevel
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
        _levelActions.Add(new LevelAction(0, 2.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 3.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 6f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(8, 2.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 10f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 11f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(8, 12f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(16, ActionTypes.Move));
        _levelActions.Add(new LevelAction(16, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.5f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(21, ActionTypes.End));
    }

}
