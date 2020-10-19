using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue 
{
    public int _ID;
    public int _dialogueType;
    public List<string> _imageNames;
    public List<string> _texts;
    public List<int> _layerToMove;
    public List<Vector2> _layerDataFrom;
    public List<Vector2> _layerDataTo;

    public Dialogue(int id, int dialogueType, List<string> imageNames, List<string> texts, List<int> layerToMove, List<Vector2> layerDataFrom, List<Vector2> layerDataTo)
    {
        _ID = id;
        _dialogueType = dialogueType;
        _imageNames = imageNames;
        _texts = texts;
        _layerToMove = layerToMove;
        _layerDataFrom = layerDataFrom;
        _layerDataTo = layerDataTo;

    }

}
