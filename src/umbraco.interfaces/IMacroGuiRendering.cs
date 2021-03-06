using System;

namespace umbraco.interfaces
{
	/// <summary>
	/// Summary description for IMacroGuiRendering.
	/// </summary>
	public interface IMacroGuiRendering
	{
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
		string Value {set; get;}
        /// <summary>
        /// Gets a value indicating whether a caption is shown
        /// </summary>
        /// <value><c>true</c> if [show caption]; otherwise, <c>false</c>.</value>
		bool ShowCaption {get;}
	}
}
