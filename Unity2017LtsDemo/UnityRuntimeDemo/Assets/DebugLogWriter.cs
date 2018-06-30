using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnityApmDemo
{
    public class DebugLogWriter : System.IO.TextWriter
    {
        public override Encoding Encoding
        {
            get
            {
                return Encoding.UTF8;
            }
        }

        public override void Write(string value)
        {
            base.Write(value);
            Debug.Log(value);
        }
    }
}
