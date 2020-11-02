using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level7 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        //CurrentSceneManager.sniper = true;
        _levelActions.Add(new LevelAction(0, 1, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 4, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(0, 6, ActionTypes.AddEnemy));
        _levelActions.Add(new LevelAction(3, ActionTypes.End));
    }

}
