using System.Data.Entity;

namespace MusicStore.Models
{
	public class MusicStoreDB : DbContext
	{
		// You can add custom code to this file. Changes will not be overwritten.
		// 
		// If you want Entity Framework to drop and regenerate your database
		// automatically whenever you change your model schema, please use data migrations.
		// For more information refer to the documentation:
		// http://msdn.microsoft.com/en-us/data/jj591621.aspx

		public MusicStoreDB() : base("name=MusicStoreDB")
		{
		}

		public DbSet<MusicStore.Models.Album> Albums { get; set; }
		public DbSet<MusicStore.Models.Artist> Artists { get; set; }
		public DbSet<MusicStore.Models.Genre> Genres { get; set; }
	}
}
