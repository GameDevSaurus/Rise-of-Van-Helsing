using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level23 : PlayableLevel
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

        _levelActions.Add(new LevelAction(3, ActionTypes.Move));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(9, ActionTypes.Move));
        _levelActions.Add(new LevelAction(9, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 8f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(17, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(17, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(17, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(17, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(17, 2f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(21, ActionTypes.End));
    }

}
