using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class Ex
{
    public static int Gold
    {
        get
        {
            return gold;
        }
        private set
        {
            gold = value;
            Save("Gold", 1000);
        }
    }

    static int gold;

    public static void DataLoad()
    {
        try
        {
            int Gold = Load("Gold", 1000);
        }
        catch (Exception e)
        {
            Gold = 10000;
        }
    }



    public static void Save<T>(string ID, T data)
    {
        AESJsonLoader.Save(ID, data);
    }
    public static T Load<T>(string ID, T dafaultValue)
    {
        return AESJsonLoader.LoadData<T>(ID, dafaultValue);
    }
}

