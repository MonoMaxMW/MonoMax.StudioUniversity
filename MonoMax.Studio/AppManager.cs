﻿using MonoMax.Studio.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoMax.Studio
{
    public class AppManager
    {
        public static AppManager Global { get; }

        static AppManager()
        {
            Global = new AppManager();

        }

        public AppManager()
        {
            Root = new Node() { Key = "Root", IsExpanded = true };
            NotificationManager = new NotificationManager();
        }

        public NotificationManager NotificationManager { get; }
        public INode Root { get; }
    }
}