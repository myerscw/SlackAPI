using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackAPI.SlackModels
{
	public class Message : SlackSocketMessage
	{
		/// <summary>
		/// Channel to send message to. Can be a public channel, private group
		/// or IM channel. Can be an encoded ID, or a name.
		/// </summary>
		[JsonProperty("channel")]
		public string Channel { get; set; }

		/// <summary>
		/// Pass true to post the message as the authed user
		/// instead of as a bot.
		/// </summary>
		[JsonProperty("as_user")]
		public bool AsUser { get; set; }

		/// <summary>
		/// Isn't always set. Should look up if not set.
		/// Name Of Bot
		/// </summary>
		[JsonProperty("username")]
		public string Username { get; set; }

		/// <summary>
		/// Text of the message to send.
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		/// <summary>
		/// Change how messages are treated.
		/// <value>"full"</value>
		/// <value>"none"</value>
		/// </summary>
		[JsonProperty("parse")]
		public string Parse { get; set; }

		/// <summary>
		/// Linkify channel names and user names by setting LinkNames
		/// to 1. Behavior is always enabled in parse=full
		/// </summary>
		[JsonProperty("link_names")]
		public short LinkNames { get; set; }

		private List<Attachment> _attachments;
		/// <summary>
		/// Structured message attachments
		/// </summary>
		[JsonProperty("attachments")]
		public List<Attachment> Attachments
		{
			get
			{
				return _attachments ?? (_attachments = new List<Attachment>());
			}
		}

		/// <summary>
		/// Pass true to enable unfurling of primarily text-based content.
		/// </summary>
		[JsonProperty("unfurl_links")]
		public bool UnfurlLinks { get; set; }

		/// <summary>
		/// Pass false to disable unfurling of media content.
		/// </summary>
		[JsonProperty("unfurl_media")]
		public bool UnfurlMedia { get; set; }

		/// <summary>
		/// URL to an iamge to use as the icon for the message.
		/// </summary>
		[JsonProperty("icon_url")]
		public string IconURL { get; set; }

		/// <summary>
		/// Emoji to use as the icon for the message.
		/// Overrides icon_url
		/// </summary>
		[JsonProperty("icon_emoji")]
		public string Emoji { get; set; }

		public bool is_starred { get; set; }
		public string permalink { get; set; }
		public DateTime ts;
		public string user { get; set; }
	}
}