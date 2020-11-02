using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level12 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        _levelActions.Add(new LevelAction(0, ActionTypes.Move));

        _levelActions.Add(new LevelAction(0, 0.5f, ActionTypes.AddEnemy));
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
        _levelActions.Add(new LevelAction(9, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 8f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 9f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(16, ActionTypes.Move));
        _levelActions.Add(new LevelAction(16, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 7f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(20, ActionTypes.Move));
        _levelActions.Add(new LevelAction(20, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 3f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(22, ActionTypes.End));
    }

}
