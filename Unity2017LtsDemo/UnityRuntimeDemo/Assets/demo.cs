using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityApmDemo
{
    public class demo : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            System.Console.SetOut(new DebugLogWriter());

            Debug.Log("Start to run shared assembly in Unity 2017 Lts with .net 3.5 compatible runtime.");

            var apm = new DemoOldAPM.OldApmDemo();
            apm.DoOldApm();

            Debug.Log("Finished.");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}


