// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using System;
using System.CodeDom.Compiler;
using System.Drawing;
#if __UNIFIED__
using UIKit;
using Foundation;
using CoreAnimation;
using CoreGraphics;
using CGPoint = global::System.Drawing.PointF;
using CGRect = global::System.Drawing.RectangleF;
using CGSize = global::System.Drawing.SizeF;
using nint = global::System.Int32;
using nfloat = global::System.Single;
using nuint = global::System.UInt32;
#else
using MonoTouch.UIKit;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreGraphics;
using MonoTouch.Foundation;
#endif

namespace HelloWorldApp
{
    [Register ("MainView")]
    partial class Form1
    {
        [Outlet]
        UIButton serializeXmlButton { get; set; }


        [Outlet]
        UIButton serializeSizeOptimizedBinary { get; set; }


        [Outlet]
        UIButton serializeBurstBinary { get; set; }


        [Outlet]
        UIButton buttonForm2 { get; set; }


        [Outlet]
        UILabel label1 { get; set; }


        [Outlet]
        UILabel label2 { get; set; }


        [Outlet]
        UIButton linkLabel1 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonForm2 != null) {
                buttonForm2.Dispose ();
                buttonForm2 = null;
            }

            if (label1 != null) {
                label1.Dispose ();
                label1 = null;
            }

            if (linkLabel1 != null) {
                linkLabel1.Dispose ();
                linkLabel1 = null;
            }

            if (serializeBurstBinary != null) {
                serializeBurstBinary.Dispose ();
                serializeBurstBinary = null;
            }

            if (serializeSizeOptimizedBinary != null) {
                serializeSizeOptimizedBinary.Dispose ();
                serializeSizeOptimizedBinary = null;
            }

            if (serializeXmlButton != null) {
                serializeXmlButton.Dispose ();
                serializeXmlButton = null;
            }
        }
    }
}