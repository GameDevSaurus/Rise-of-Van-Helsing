using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level39 : PlayableLevel
{
    bool updated;
    bool moveAtStart;
    public override void Initialize()
    {
        base.Init();
        //CurrentSceneManager.sniper = true;
        _levelActions.Add(new LevelAction(0, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 0.1f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 1.3f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 2.6f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 3.9f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 4.1f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 5.2f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 6.3f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 7.9f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 8.1f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 9.2f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 10.3f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 11.9f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 12.1f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 13.2f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(0, 14.3f, ActionTypes.Move));


        _levelActions.Add(new LevelAction(15, ActionTypes.Move));
        _levelActions.Add(new LevelAction(15, 0.1f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(15, 0.2f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(15, 0.3f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(15, 0.4f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(15, 0.5f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(15, 0.6f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(15, 0.7f, ActionTypes.Move));


        _levelActions.Add(new LevelAction(22, ActionTypes.Move));
        _levelActions.Add(new LevelAction(22, 0.1f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(22, 1.3f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(22, 2.6f, ActionTypes.Move));


        _levelActions.Add(new LevelAction(25, ActionTypes.Move));
        _levelActions.Add(new LevelAction(25, 0.1f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(25, 1.3f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(25, 2.6f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(25, 3.7f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(25, 4.8f, ActionTypes.Move));
        _levelActions.Add(new LevelAction(25, 5.9f, ActionTypes.Move));

        _levelActions.Add(new LevelAction(5, ActionTypes.End));
    }

}
