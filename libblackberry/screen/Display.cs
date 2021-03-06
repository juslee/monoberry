using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace BlackBerry.Screen
{
	public class Display
	{
		[DllImport ("screen")]
		static extern int screen_get_display_property_iv (IntPtr handle, Property prop, out int val);
		
		[DllImport ("screen")]
		static extern int screen_get_display_property_iv (IntPtr handle, Property prop, [Out] int[] vals);
		
		[DllImport ("screen")]
		static extern int screen_set_display_property_iv (IntPtr handle, Property prop, ref int val);

		IntPtr handle;

		public Display (IntPtr hnd) {
			handle = hnd;
		}

		public Size Size {
			get {
				var rect = new int [2];
				screen_get_display_property_iv (handle, Property.SCREEN_PROPERTY_SIZE, rect);
				return new Size (rect[0], rect[1]);
			}
		}

		public DisplayType Type {
			get {
				return (DisplayType)GetIntProperty (Property.SCREEN_PROPERTY_TYPE);
			}
		}

		int GetIntProperty (Property p)
		{
			int result;
			if (screen_get_display_property_iv (handle, p, out result) != 0) {
				throw new Exception ("Unable to read display property " + p);
			}
			return result;
		}
		
		void SetIntProperty (Property p, int val)
		{
			if (screen_set_display_property_iv (handle, p, ref val) != 0) {
				throw new Exception ("Unable to set display property " + p);
			}
		}

	}
}

