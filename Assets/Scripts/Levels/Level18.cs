using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level18 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        //CurrentSceneManager.sniper = true;
        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 3.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 9.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 11f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 13.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 15f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 17f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 19.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 21f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 22f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 23f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 24f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(15, ActionTypes.Move));
        _levelActions.Add(new LevelAction(15, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(15, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(15, 3.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(15, 5f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(19, ActionTypes.Move));
        _levelActions.Add(new LevelAction(19, 0.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 3.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 7f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(19, 11f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(26, ActionTypes.End));
    }

}
