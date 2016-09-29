using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using UnityEngine;

public static class UniChain
{
    [UnityEditor.InitializeOnLoadMethod]
    public static void Init()
    {
        Process.Start(
            Application.dataPath + "/../unichain/unichain.exe",
            Application.dataPath);
    }
} 

public class InjectAttribute : Attribute
{
    public InjectAttribute(Type type)
    {
    }
}
