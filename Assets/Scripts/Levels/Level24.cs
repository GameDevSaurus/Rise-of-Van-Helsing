using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level24 : PlayableLevel
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
        _levelActions.Add(new LevelAction(0, 2.2f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(6, ActionTypes.Move));
        _levelActions.Add(new LevelAction(6, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 5f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(12, ActionTypes.Move));
        _levelActions.Add(new LevelAction(12, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 8f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(19, ActionTypes.Move));
        _levelActions.Add(new LevelAction(19, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 1f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(25, ActionTypes.End));
    }

}
