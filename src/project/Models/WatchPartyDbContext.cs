﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WatchParty.Models;

public partial class WatchPartyDbContext : DbContext
{
    public WatchPartyDbContext()
    {
    }

    public WatchPartyDbContext(DbContextOptions<WatchPartyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LikePost> LikePosts { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<Reshare> Reshares { get; set; }

    public virtual DbSet<Watcher> Watchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Name=WatchPartyConnection");
        }

        optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LikePost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LikePost__3214EC279821771D");

            entity.HasOne(d => d.Post).WithMany(p => p.LikePosts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_LikePost_PostID");

            entity.HasOne(d => d.User).WithMany(p => p.LikePosts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_LikePost_UserID");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Post__3214EC27F914DBA5");

            entity.HasOne(d => d.User).WithMany(p => p.Posts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_Post_UserID");
        });

        modelBuilder.Entity<Reshare>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reshare__3214EC275F6BD774");

            entity.HasOne(d => d.Post).WithMany(p => p.Reshares)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_Reshare_PostID");

            entity.HasOne(d => d.User).WithMany(p => p.Reshares)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_Reshare_UserID");
        });

        modelBuilder.Entity<Watcher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Watcher__3214EC2786AADE2B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}