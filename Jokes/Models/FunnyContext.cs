using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Jokes.Models;

public partial class FunnyContext : DbContext
{
    public FunnyContext()
    {
    }

    public FunnyContext(DbContextOptions<FunnyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Joke> Jokes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=bit.uni-corvinus.hu;Initial Catalog=FunnyDatabase;User ID=hallgato2;Password=Password123; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Joke>(entity =>
        {
            entity.HasKey(e => e.JokeSk);

            entity.ToTable("Joke");

            entity.Property(e => e.JokeSk).HasColumnName("JokeSK");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
