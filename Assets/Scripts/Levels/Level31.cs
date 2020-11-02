using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level31 : PlayableLevel
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
        _levelActions.Add(new LevelAction(3, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, 0.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, 0.3f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(6, ActionTypes.Move));
        _levelActions.Add(new LevelAction(6, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 0.6f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(9, ActionTypes.Move));
        _levelActions.Add(new LevelAction(9, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 0.6f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(12, ActionTypes.Move));
        _levelActions.Add(new LevelAction(12, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 0.6f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(15, ActionTypes.Move));
        _levelActions.Add(new LevelAction(15, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(15, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(15, 0.6f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(18, ActionTypes.Move));
        _levelActions.Add(new LevelAction(18, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(18, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(18, 0.6f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(21, ActionTypes.Move));
        _levelActions.Add(new LevelAction(21, 3.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(21, 3.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(21, 3.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(21, 3.4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(21, 3.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(21, 3.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(21, 3.7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(21, 3.8f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(21, 3.9f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(30, ActionTypes.End));
    }

}
