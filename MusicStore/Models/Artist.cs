using System.ComponentModel;

namespace MusicStore.Models
{
	public class Artist
	{
		public virtual int ArtistId { get; set; }

		[DisplayName("Artist")]
		public virtual string Name { get; set; }
	}
}