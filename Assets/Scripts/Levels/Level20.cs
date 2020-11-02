using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level20 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        //CurrentSceneManager.sniper = true;
        _levelActions.Add(new LevelAction(0, ActionTypes.Move));

        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 4f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(6, ActionTypes.Move));
        _levelActions.Add(new LevelAction(6, 3.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 8f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 9.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 10f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 12f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 14f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 16f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(16, ActionTypes.Move));
        _levelActions.Add(new LevelAction(16, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.8f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 1f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(22, ActionTypes.End));
    }

}
