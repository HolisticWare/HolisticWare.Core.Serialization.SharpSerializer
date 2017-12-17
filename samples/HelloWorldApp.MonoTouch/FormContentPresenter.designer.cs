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
using CGPoint = global::System.Drawing.PointF;
using CGRect = global::System.Drawing.RectangleF;
using CGSize = global::System.Drawing.SizeF;
using nint = global::System.Int32;
using nfloat = global::System.Single;
using nuint = global::System.UInt32;
using CoreAnimation;
using CoreGraphics;
#else
using MonoTouch.UIKit;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreGraphics;
using MonoTouch.Foundation;
#endif

namespace HelloWorldApp
{
    [Register ("FormContentPresenter")]
    partial class FormContentPresenter
    {
        [Outlet]
        UITextView textBoxContent { get; set; }


        [Outlet]
        UINavigationItem contentTitle { get; set; }


        [Action ("buttonDone:")]
        partial void buttonDone (NSObject sender);

        void ReleaseDesignerOutlets ()
        {
            if (contentTitle != null) {
                contentTitle.Dispose ();
                contentTitle = null;
            }

            if (textBoxContent != null) {
                textBoxContent.Dispose ();
                textBoxContent = null;
            }
        }
    }
}