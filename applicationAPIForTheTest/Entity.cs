﻿namespace applicationAPIForTheTest
{
    public abstract class Entity<TId>
    {
        public TId Id { get; protected set; }
    }
}
