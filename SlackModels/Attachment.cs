using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SlackAPI.SlackModels
{
	public class Attachment
	{
		/// <summary>
		/// A plain-text summary of the attachment. Thix text will be used in clients
		/// that don't show formatted text (IRC, mobile notifications) and should not
		/// contain any markup.
		/// </summary>
		[JsonProperty("fallback")]
		public string Fallback { get; set; }

		/// <summary>
		/// An optional value that can either be one of good, warning, danger, or any hex color.
		/// 
		/// Good = Green
		/// Warning = Yellow
		/// Danger = Red
		/// </summary>
		[JsonProperty("color")]
		public string Color { get; set; }

		/// <summary>
		/// Optional text that appears above the message attachment block.
		/// </summary>
		[JsonProperty("pretext")]
		public string Pretext { get; set; }

		/// <summary>
		/// Small text used to display the author's name
		/// </summary>
		[JsonProperty("author_name")]
		public string AuthorName { get; set; }

		/// <summary>
		/// A valid URL that will hyperlink the author name text
		/// Will only work if Author Name is present
		/// </summary>
		[JsonProperty("author_link")]
		public string AuthorLink { get; set; }

		/// <summary>
		/// A valid URL that displays a small 16x16px image to the left of the author name
		/// text. Only works if author name is present.
		/// </summary>
		[JsonProperty("author_icon")]
		public string AuthorIcon { get; set; }

		/// <summary>
		/// Dispalyed as larger, bold text near the top of a message attachment. By passing
		/// a valid URL in the title link parameter, the title text will be hyperlinked
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// The value of the hyperlink for the title attribute
		/// </summary>
		[JsonProperty("title_link")]
		public string TitleLink { get; set; }

		/// <summary>
		/// Main text in a message attachment and can contain standard message markup. The content
		/// will automatically collapse if it contains 700+ characters or 5+ linebreaks and display
		/// a "Show more..." link to expand the content.
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		private List<Field> _fields;
		/// <summary>
		/// Are defined as an array and hashed contained within it will be displayed in a table inside the
		/// message attachment.
		/// </summary>
		[JsonProperty("fields")]
		public List<Field> Fields
		{
			get
			{
				return _fields ?? (_fields = new List<Field>());
			}
		}

		/// <summary>
		/// A valid URL to an image file that will be displayed inside a message attachment.
		/// Currently support the following formats: GIF, JPEG, PNG, and BMP.
		/// 
		/// Large images will be resized to a max 500px x 400px, maintaining aspect ratio.
		/// </summary>
		[JsonProperty("image_url")]
		public string ImageURL { get; set; }

		public Attachment() { }
		
		public Attachment(string Title, string TitleLink, string Text, string Fallback, string Color, List<Field> Fields = null) {
			this.Title = Title;
			this.Text = Text;
			this.TitleLink = TitleLink;
			this.Fallback = Fallback;
			this.Color = Color;
			if (Fields != null)
			{
				this._fields = Fields;
			}
		}

		public Attachment(string Title, string TitleLink, string Text, List<Field> Fields, string Fallback, string Color, string PreText, string AuthorName, string AuthorLink, string AuthorIcon, string ImageURL)
		{
			this.Title = Title;
			this.TitleLink = TitleLink;
			this.Text = Text;
			this._fields = Fields;
			this.Fallback = Fallback;
			this.Color = Color;
			this.Pretext = Pretext;
			this.AuthorIcon = AuthorIcon;
			this.AuthorLink = AuthorLink;
			this.AuthorName = AuthorName;
			this.ImageURL = ImageURL;
		}
	}
}
