using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level34 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1.15f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 2.16f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 3.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 4.21f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 5.22f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 6.23f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 7.24f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 8.25f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 9.26f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(10, ActionTypes.Move));
        _levelActions.Add(new LevelAction(10, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 1.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 2.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 3.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 4.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 5.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 6.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 7.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 8.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(10, 9.2f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(20, ActionTypes.Move));
        _levelActions.Add(new LevelAction(20, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 0.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 0.7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 0.8f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 0.85f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 0.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 1.01f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 1.02f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 1.03f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(30, ActionTypes.Move));
        _levelActions.Add(new LevelAction(30, 1.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(30, 1.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(30, 1.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(30, 1.7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(30, 1.8f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(35, ActionTypes.End));
    }

}
