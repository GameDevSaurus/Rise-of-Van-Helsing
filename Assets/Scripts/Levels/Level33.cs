using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level33 : PlayableLevel
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
        _levelActions.Add(new LevelAction(0, 5.2f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 6.3f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(9, ActionTypes.Move));
        _levelActions.Add(new LevelAction(9, 0.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 1.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 2.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 3.1f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 4.3f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 6.6f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 7.9f, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(9, 8.1f, ActionTypes.AddEnemy));

        _levelActions.Add(new LevelAction(17, ActionTypes.Move));
        _levelActions.Add(new LevelAction(17, 3.1f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(17, 4.3f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(17, 5.6f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(17, 6.3f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(17, 9.6f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(17, 10.9f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(17, 12.1f, ActionTypes.Move));

        _levelActions.Add(new LevelAction(24, ActionTypes.Move));
        _levelActions.Add(new LevelAction(24, 0.1f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(24, 0.2f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(24, 0.3f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(24, 0.4f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(24, 0.5f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(24, 0.6f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(24, 0.7f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(24, 0.8f, ActionTypes.Move));

        _levelActions.Add(new LevelAction(32, ActionTypes.End));
    }

}
