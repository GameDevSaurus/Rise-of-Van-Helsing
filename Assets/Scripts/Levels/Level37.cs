using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level37 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        //CurrentSceneManager.sniper = true;

        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 1.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 2.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 4.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 6.3f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(7, ActionTypes.Move));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 4.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 6.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 8f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 8.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 9.2f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(16, ActionTypes.Move));
        _levelActions.Add(new LevelAction(16, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 4.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 6.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 7.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 8.1f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(23, ActionTypes.Move));
        _levelActions.Add(new LevelAction(23, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(23, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(23, 0.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(23, 4.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(23, 6.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(23, 7.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(23, 8.1f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(30, ActionTypes.End));
    }

}
