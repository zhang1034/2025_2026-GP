using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AH3829
{
public class Data
{
    public int id;
    public string name;
    public int score;

    public Data(int id, string name)
    {
        this.id = id;
        this.name = name;
        score = 0;
    }

    public void SetScore(int value)
    {
        score = value;
    }
}
}