using Microsoft.EntityFrameworkCore;
using Model.Mahasiswa;

class MahasiswaDB : DbContext
{
    public MahasiswaDB(DbContextOptions<MahasiswaDB> options) // default setting untuk database
        : base(options) { }
    public DbSet<Mahasiswa> mhs => Set<Mahasiswa>();
}
