using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level19 : PlayableLevel
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
        _levelActions.Add(new LevelAction(11, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, 5f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(16, ActionTypes.Move));
        _levelActions.Add(new LevelAction(16, 2.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 8f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(22, ActionTypes.End));
    }

}
