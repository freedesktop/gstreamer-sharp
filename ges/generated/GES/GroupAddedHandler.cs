// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;

	public delegate void GroupAddedHandler(object o, GroupAddedArgs args);

	public class GroupAddedArgs : GLib.SignalArgs {
		public GES.Group Group{
			get {
				return (GES.Group) Args [0];
			}
		}

	}
}
