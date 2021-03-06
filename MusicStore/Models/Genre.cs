﻿using System.Collections.Generic;
using System.ComponentModel;

namespace MusicStore.Models
{
	public class Genre
	{
		public virtual int GenreId { get; set; }

		[DisplayName("Genre")]
		public virtual string Name { get; set; }

		public virtual string Description { get; set; }
		public virtual List<Album> Albums { get; set; }
	}
}