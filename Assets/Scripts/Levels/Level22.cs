using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level22 : PlayableLevel
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
        _levelActions.Add(new LevelAction(0, 5f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(7, ActionTypes.Move));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(7, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(13, ActionTypes.Move));
        _levelActions.Add(new LevelAction(13, 0.5f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(14, ActionTypes.Move));
        _levelActions.Add(new LevelAction(14, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(14, 0.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(14, 0.7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(14, 0.8f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(14, 5.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(14, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(14, 9.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(14, 11.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(14, 14.7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(14, 16.8f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(14, 18.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(14, 20f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(14, 22f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(27, ActionTypes.End));
    }

}
