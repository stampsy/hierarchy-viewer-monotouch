using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iOSHV
{
    [BaseType(typeof(NSObject))]
    interface iOSHierarchyViewer {
        [Static, Export("start")]
        bool Start();

        [Static, Export("stop")]
        void Stop();
    }
}

