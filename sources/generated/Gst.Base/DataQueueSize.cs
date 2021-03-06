// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Base {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct DataQueueSize : IEquatable<DataQueueSize> {

		public uint Visible;
		public uint Bytes;
		public ulong Time;

		public static Gst.Base.DataQueueSize Zero = new Gst.Base.DataQueueSize ();

		public static Gst.Base.DataQueueSize New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Base.DataQueueSize.Zero;
			return (Gst.Base.DataQueueSize) Marshal.PtrToStructure (raw, typeof (Gst.Base.DataQueueSize));
		}

		public bool Equals (DataQueueSize other)
		{
			return true && Visible.Equals (other.Visible) && Bytes.Equals (other.Bytes) && Time.Equals (other.Time);
		}

		public override bool Equals (object other)
		{
			return other is DataQueueSize && Equals ((DataQueueSize) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Visible.GetHashCode () ^ Bytes.GetHashCode () ^ Time.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
