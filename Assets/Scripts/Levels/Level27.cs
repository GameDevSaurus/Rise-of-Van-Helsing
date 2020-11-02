using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level27 : PlayableLevel
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
        _levelActions.Add(new LevelAction(0, 6.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 7.5f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 8.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 9.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 11f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(11, ActionTypes.Move));
        _levelActions.Add(new LevelAction(11, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, 4.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, 6.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, 7.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, 8.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(11, 9.2f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(17, ActionTypes.Move));
        _levelActions.Add(new LevelAction(17, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(17, 0.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(17, 0.6f, ActionTypes.AddEnemy));


        _levelActions.Add(new LevelAction(20, ActionTypes.Move));
        _levelActions.Add(new LevelAction(20, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 4.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 6.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 7.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 8f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(20, 10f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(27, ActionTypes.End));
    }

}
