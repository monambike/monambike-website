using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Monambike.WebAPI.Data;

public partial class MonambikeContext : DbContext
{
    public MonambikeContext()
    {
    }

    public MonambikeContext(DbContextOptions<MonambikeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Follow> Follows { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Meaning> Meanings { get; set; }

    public virtual DbSet<MediaType> MediaTypes { get; set; }

    public virtual DbSet<Medium> Media { get; set; }

    public virtual DbSet<Phone> Phones { get; set; }

    public virtual DbSet<Platform> Platforms { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<PostTag> PostTags { get; set; }

    public virtual DbSet<Progress> Progresses { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<Token> Tokens { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserMedium> UserMedia { get; set; }

    public virtual DbSet<Visibility> Visibilities { get; set; }

    public virtual DbSet<Word> Words { get; set; }

    public virtual DbSet<WordRelation> WordRelations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=monambike.database.windows.net; Database=MONAMBIKE; User ID=monambike; Password=Monam110!; Trusted_Connection=False;Encrypt=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_AddressID");

            entity.ToTable("Address", "account");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.Number)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.City).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_Address_CityID");

            entity.HasOne(d => d.Country).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Address_CountryID");

            entity.HasOne(d => d.Region).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK_Address_RegionID");

            entity.HasOne(d => d.User).WithOne(p => p.Address)
                .HasForeignKey<Address>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_UserID");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK_CityID");

            entity.ToTable("City", "location");

            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");

            entity.HasOne(d => d.Region).WithMany(p => p.Cities)
                .HasForeignKey(d => d.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_City_RegionID");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK_CommentID");

            entity.ToTable("Comment", "publication");

            entity.Property(e => e.CommentId)
                .ValueGeneratedNever()
                .HasColumnName("CommentID");
            entity.Property(e => e.DateTime).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PostId).HasColumnName("PostID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.CommentNavigation).WithOne(p => p.Comment)
                .HasForeignKey<Comment>(d => d.CommentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comment_UserID");

            entity.HasOne(d => d.Post).WithMany(p => p.Comments)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comment_PostID");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK_CountryID");

            entity.ToTable("Country", "location");

            entity.HasIndex(e => e.Abbreviation, "AK_Country_Abbreviation").IsUnique();

            entity.HasIndex(e => e.Name, "AK_Country_Name").IsUnique();

            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Follow>(entity =>
        {
            entity.HasKey(e => new { e.FollowerId, e.FollowedId });

            entity.ToTable("Follow", "account");

            entity.Property(e => e.FollowerId).HasColumnName("FollowerID");
            entity.Property(e => e.FollowedId).HasColumnName("FollowedID");
            entity.Property(e => e.FollowDateTime).HasDefaultValueSql("(getutcdate())");

            entity.HasOne(d => d.Followed).WithMany(p => p.FollowFolloweds)
                .HasForeignKey(d => d.FollowedId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Follow_UserID (Followed)");

            entity.HasOne(d => d.Follower).WithMany(p => p.FollowFollowers)
                .HasForeignKey(d => d.FollowerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Follow_UserID (Follower)");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK_GroupID");

            entity.ToTable("Group", "medias");

            entity.Property(e => e.GroupId)
                .ValueGeneratedNever()
                .HasColumnName("GroupID");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.GroupNavigation).WithOne(p => p.Group)
                .HasForeignKey<Group>(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Group_UserID");

            entity.HasMany(d => d.Media).WithMany(p => p.Groups)
                .UsingEntity<Dictionary<string, object>>(
                    "MediaGroup",
                    r => r.HasOne<Medium>().WithMany()
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MediaGroup_MediaID"),
                    l => l.HasOne<Group>().WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MediaGroup_GroupID"),
                    j =>
                    {
                        j.HasKey("GroupId", "MediaId").HasName("PK_MediaGroupID");
                        j.ToTable("MediaGroup", "medias");
                    });
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_LoginID");

            entity.ToTable("Login", "account");

            entity.HasIndex(e => e.Username, "AK_Login_Username").IsUnique();

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.PhoneId).HasColumnName("PhoneID");
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.User).WithOne(p => p.Login)
                .HasForeignKey<Login>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Login_UserID");
        });

        modelBuilder.Entity<Meaning>(entity =>
        {
            entity.HasKey(e => e.WordId);

            entity.ToTable("Meaning", "dictionary");

            entity.HasIndex(e => e.WordId, "AK_Meaning_WordID").IsUnique();

            entity.Property(e => e.WordId)
                .ValueGeneratedNever()
                .HasColumnName("WordID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Example).HasMaxLength(225);

            entity.HasOne(d => d.Word).WithOne(p => p.Meaning)
                .HasForeignKey<Meaning>(d => d.WordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Meaning_WordID");
        });

        modelBuilder.Entity<MediaType>(entity =>
        {
            entity.HasKey(e => e.MediaTypeId).HasName("PK_MediaTypeID");

            entity.ToTable("MediaType", "medias");

            entity.HasIndex(e => e.Name, "AK_Media_Name").IsUnique();

            entity.Property(e => e.MediaTypeId)
                .ValueGeneratedNever()
                .HasColumnName("MediaTypeID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Medium>(entity =>
        {
            entity.HasKey(e => e.MediaId).HasName("PK_MediaID");

            entity.ToTable("Media", "medias");

            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasMany(d => d.Progresses).WithMany(p => p.Media)
                .UsingEntity<Dictionary<string, object>>(
                    "MediaProgress",
                    r => r.HasOne<Progress>().WithMany()
                        .HasForeignKey("ProgressId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MediaProgress_ProgressID"),
                    l => l.HasOne<Medium>().WithMany()
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MediaProgress_MediaID"),
                    j =>
                    {
                        j.HasKey("MediaId", "ProgressId").HasName("PK_MediaProgressID");
                        j.ToTable("MediaProgress", "medias");
                    });

            entity.HasMany(d => d.Tags).WithMany(p => p.Media)
                .UsingEntity<Dictionary<string, object>>(
                    "MediaTag",
                    r => r.HasOne<Tag>().WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MediaTag_TagID"),
                    l => l.HasOne<Medium>().WithMany()
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MediaTag_MediaID"),
                    j =>
                    {
                        j.HasKey("MediaId", "TagId").HasName("PK_MediaTagID");
                        j.ToTable("MediaTag", "medias");
                    });
        });

        modelBuilder.Entity<Phone>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_PhoneID");

            entity.ToTable("Phone", "account");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.CompletePhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('CountryCodeID + DDD + Number')");
            entity.Property(e => e.CountryCodeId).HasColumnName("CountryCodeID");
            entity.Property(e => e.Ddd)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("DDD");
            entity.Property(e => e.Number)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.User).WithOne(p => p.Phone)
                .HasForeignKey<Phone>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Phone_UserID");
        });

        modelBuilder.Entity<Platform>(entity =>
        {
            entity.HasKey(e => e.PlatformId).HasName("PK_PlatformID");

            entity.ToTable("Platform", "medias");

            entity.HasIndex(e => e.Name, "AK_Platform_Name").IsUnique();

            entity.Property(e => e.PlatformId)
                .ValueGeneratedNever()
                .HasColumnName("PlatformID");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasMany(d => d.Media).WithMany(p => p.Platforms)
                .UsingEntity<Dictionary<string, object>>(
                    "MediaPlatform",
                    r => r.HasOne<Medium>().WithMany()
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MediaPlatform_MediaID"),
                    l => l.HasOne<Platform>().WithMany()
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MediaPlatform_PlatformID"),
                    j =>
                    {
                        j.HasKey("PlatformId", "MediaId").HasName("PK_MediaPlatformID");
                        j.ToTable("MediaPlatform", "medias");
                    });
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK_PostID");

            entity.ToTable("Post", "publication");

            entity.Property(e => e.PostId)
                .ValueGeneratedNever()
                .HasColumnName("PostID");
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.VisibilityId).HasColumnName("VisibilityID");

            entity.HasOne(d => d.Visibility).WithMany(p => p.Posts)
                .HasForeignKey(d => d.VisibilityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Post_VisibilityID");
        });

        modelBuilder.Entity<PostTag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PostTag", "publication");

            entity.Property(e => e.PostId).HasColumnName("PostID");
            entity.Property(e => e.TagId).HasColumnName("TagID");
        });

        modelBuilder.Entity<Progress>(entity =>
        {
            entity.HasKey(e => e.ProgressId).HasName("PK_ProgressID");

            entity.ToTable("Progress", "medias");

            entity.HasIndex(e => e.Name, "AK_Progress_Name").IsUnique();

            entity.Property(e => e.ProgressId).HasColumnName("ProgressID");
            entity.Property(e => e.Name)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK_RegionID");

            entity.ToTable("Region", "location");

            entity.HasIndex(e => e.Abbreviation, "AK_Region_Abbreviation").IsUnique();

            entity.HasIndex(e => e.Name, "AK_Region_Name").IsUnique();

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.HasOne(d => d.Country).WithMany(p => p.Regions)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Region_CountryID");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_SettingsID");

            entity.ToTable("Settings", "account");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.PrimaryColor)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SecondaryColor)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.User).WithOne(p => p.Setting)
                .HasForeignKey<Setting>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Settings_UserID");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PK_TagID");

            entity.ToTable("Tag", "medias");

            entity.Property(e => e.TagId).HasColumnName("TagID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Tags)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tag_UserID");
        });

        modelBuilder.Entity<Token>(entity =>
        {
            entity.HasKey(e => e.TokenId).HasName("PK_TokenID");

            entity.ToTable("Token", "publication");

            entity.HasIndex(e => e.CodeUid, "AK_Token_Code").IsUnique();

            entity.Property(e => e.TokenId)
                .ValueGeneratedNever()
                .HasColumnName("TokenID");
            entity.Property(e => e.CodeUid).HasColumnName("CodeUID");
            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PostId).HasColumnName("PostID");

            entity.HasOne(d => d.Post).WithMany(p => p.Tokens)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Token_PostID");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_UserID");

            entity.ToTable("User", "account");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.Biography).HasMaxLength(500);
            entity.Property(e => e.ExibitionName)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'FirstName')");
            entity.Property(e => e.RealName).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(128);
        });

        modelBuilder.Entity<UserMedium>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.MediaId });

            entity.ToTable("UserMedia", "medias");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.LinkDate).HasDefaultValueSql("(getutcdate())");

            entity.HasOne(d => d.Media).WithMany(p => p.UserMedia)
                .HasForeignKey(d => d.MediaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserMedia_MediaID");

            entity.HasOne(d => d.User).WithMany(p => p.UserMedia)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserMedia_UserID");
        });

        modelBuilder.Entity<Visibility>(entity =>
        {
            entity.HasKey(e => e.VisibilityId).HasName("PK_VisibilityID");

            entity.ToTable("Visibility", "publication");

            entity.HasIndex(e => e.Name, "AK_Visibility_Name").IsUnique();

            entity.Property(e => e.VisibilityId)
                .ValueGeneratedNever()
                .HasColumnName("VisibilityID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Word>(entity =>
        {
            entity.HasKey(e => e.WordId).HasName("PK_WordID");

            entity.ToTable("Word", "dictionary");

            entity.Property(e => e.WordId)
                .ValueGeneratedNever()
                .HasColumnName("WordID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");
        });

        modelBuilder.Entity<WordRelation>(entity =>
        {
            entity.HasKey(e => new { e.WordId, e.ReferenceId }).HasName("PK_WordRelationID");

            entity.ToTable("WordRelation", "dictionary");

            entity.Property(e => e.WordId).HasColumnName("WordID");
            entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

            entity.HasOne(d => d.Reference).WithMany(p => p.WordRelationReferences)
                .HasForeignKey(d => d.ReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WordRelation_WordID (Reference)");

            entity.HasOne(d => d.Word).WithMany(p => p.WordRelationWords)
                .HasForeignKey(d => d.WordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WordRelation_WordID (Word)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
