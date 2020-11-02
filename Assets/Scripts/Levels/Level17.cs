using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level17 : PlayableLevel
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
        _levelActions.Add(new LevelAction(0, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 4f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(6, ActionTypes.Move));
        _levelActions.Add(new LevelAction(6, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 5f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(11, ActionTypes.Move));
        _levelActions.Add(new LevelAction(11, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(16, ActionTypes.Move));
        _levelActions.Add(new LevelAction(16, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(3, ActionTypes.End));
    }

}
