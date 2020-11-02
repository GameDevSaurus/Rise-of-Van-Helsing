using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level15 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        //CurrentSceneManager.sniper = true;
        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0,2.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 3.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 5.5f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(6, ActionTypes.Move));
        _levelActions.Add(new LevelAction(6, 2.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 4f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(6, 9f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(11, ActionTypes.Move));
        _levelActions.Add(new LevelAction(11, 2.1f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(12, ActionTypes.Move));
        _levelActions.Add(new LevelAction(12, 4.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 5.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 6.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 7.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 8.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 9.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 10.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(12, 11.1f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(20, ActionTypes.Move));
        _levelActions.Add(new LevelAction(20, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(24, ActionTypes.End));
    }

}
