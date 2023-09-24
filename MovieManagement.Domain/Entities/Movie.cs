﻿namespace MovieManagement.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ActorId { get; set; }
        public Actor? Actors { get; set; }
        public List<Genre>? Genre { get; set; }
    }
}