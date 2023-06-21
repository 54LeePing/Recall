using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Content", menuName = "ScriptableObjects/Content")]
public class Content : ScriptableObject
{
    public List<String> sentences;
}
