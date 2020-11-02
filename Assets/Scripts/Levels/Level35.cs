using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level35 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        //CurrentSceneManager.sniper = true;
        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 1.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 2.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 3.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 4.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 5.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 6.3f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(7, ActionTypes.Move));
        _levelActions.Add(new LevelAction(7, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 1.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 2.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 3.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 4.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 6.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 7.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 8.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 9.2f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(16, ActionTypes.Move));
        _levelActions.Add(new LevelAction(16, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 0.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 6.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 7.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 8.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(16, 4.3f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(23, ActionTypes.Move));
        _levelActions.Add(new LevelAction(23, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(23, 0.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(23, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(23, 0.4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(23, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(23, 0.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(23, 0.7f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(30, ActionTypes.End));
    }

}
