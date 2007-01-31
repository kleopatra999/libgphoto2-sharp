using System;
using System.Runtime.InteropServices;

namespace Gphoto2.Base
{
    public class Context : Object
    {
        public Context ()
        {
            this.handle = new HandleRef (this, gp_context_new ());
        }
        
        protected override void Cleanup ()
        {
            gp_context_unref(handle);
        }

        [DllImport ("libgphoto2.so")]
        internal static extern IntPtr gp_context_new ();

        [DllImport ("libgphoto2.so")]
        internal static extern void gp_context_unref   (HandleRef context);
    }
}