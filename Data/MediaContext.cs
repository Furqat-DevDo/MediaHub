global using Microsoft.EntityFrameworkCore;
using MediaApi.Entities;

namespace MediaApi.Data;
public class MediaContext:DbContext
{
  DbSet <Advers> Ads {get;set;}
  DbSet<Media> Medias {get;set;}
  public MediaContext(DbContextOptions options)
  :base (options) {}
}