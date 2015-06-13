using System;
using Newtonsoft.Json;

namespace SlackAPI.SlackModels
{
	public class Field
	{
		/// <summary>
		/// Shown as bold heading above the value text. Itcannot contain markup
		/// and will be escaped
		/// </summary>
		[JsonProperty("title")]
		public string Title;

		/// <summary>
		/// The text value of the field. It may contain standard message markup and must be escaped as normal.
		/// May be multi-lined.
		/// </summary>
		[JsonProperty("value")]
		public string Value;

		/// <summary>
		/// Optional flag indicating whether the value is short enough to be displayed
		/// side-by-side
		/// </summary>
		[JsonProperty("short")]
		public bool Short;

		public Field() { }

		public Field(string Title, string Value, bool Short)
		{
			this.Title = Title;
			this.Value = Value;
			this.Short = Short;
		}
	}
}