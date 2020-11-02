using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level26 : PlayableLevel
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
        _levelActions.Add(new LevelAction(6, 3f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(7, ActionTypes.Move));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 2.53f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 10f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 12f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, 13f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(17, ActionTypes.Move));
        _levelActions.Add(new LevelAction(17, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(17, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(17, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(17, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(17, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(17, 1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(17, 1f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(24, ActionTypes.Move));
        _levelActions.Add(new LevelAction(24, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(24, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(24, 2f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(27, ActionTypes.End));
    }

}
