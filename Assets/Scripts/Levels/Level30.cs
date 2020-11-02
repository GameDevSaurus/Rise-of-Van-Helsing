using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level30 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();

        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 2.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 3.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 4.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 5.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 6.3f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(7, ActionTypes.Move));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 1.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 2.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 3.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 4.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 6.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 8f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 8.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 9.2f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(16, ActionTypes.Move));
        _levelActions.Add(new LevelAction(16, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.6f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(19, ActionTypes.Move));
        _levelActions.Add(new LevelAction(19, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 0.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 0.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 0.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 0.1f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(5, ActionTypes.End));
    }

}
