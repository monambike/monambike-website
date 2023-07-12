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

    public virtual DbSet<Dictionary> Dictionaries { get; set; }

    public virtual DbSet<Follow> Follows { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Meaning> Meanings { get; set; }

    public virtual DbSet<MediaProgress> MediaProgresses { get; set; }

    public virtual DbSet<Medium> Media { get; set; }

    public virtual DbSet<Phone> Phones { get; set; }

    public virtual DbSet<Platform> Platforms { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<Progress> Progresses { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<Tag1> Tags1 { get; set; }

    public virtual DbSet<Theme> Themes { get; set; }

    public virtual DbSet<Token> Tokens { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserMediaTag> UserMediaTags { get; set; }

    public virtual DbSet<UserMedium> UserMedia { get; set; }

    public virtual DbSet<UserTag> UserTags { get; set; }

    public virtual DbSet<Visibility> Visibilities { get; set; }

    public virtual DbSet<Word> Words { get; set; }

    public virtual DbSet<WordRelation> WordRelations { get; set; }

    public virtual DbSet<WordRelationType> WordRelationTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=monambike.database.windows.net; Database=MONAMBIKE; User ID=monambike; Password=Monam110!; Trusted_Connection=False;Encrypt=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("Address", "account");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Complement).HasMaxLength(50);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.Number).HasMaxLength(50);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.Street).HasMaxLength(100);

            entity.HasOne(d => d.City).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_Address_City");

            entity.HasOne(d => d.Country).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Address_Country");

            entity.HasOne(d => d.Region).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK_Address_Region");

            entity.HasOne(d => d.User).WithOne(p => p.Address)
                .HasForeignKey<Address>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_User");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.ToTable("City", "location");

            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(60);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");

            entity.HasOne(d => d.Region).WithMany(p => p.Cities)
                .HasForeignKey(d => d.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_City_Region");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.ToTable("Comment", "publication");

            entity.Property(e => e.CommentId)
                .ValueGeneratedNever()
                .HasColumnName("CommentID");
            entity.Property(e => e.DateTime).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.PostId).HasColumnName("PostID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.CommentNavigation).WithOne(p => p.Comment)
                .HasForeignKey<Comment>(d => d.CommentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comment_User");

            entity.HasOne(d => d.Post).WithMany(p => p.Comments)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comment_Post");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country", "location");

            entity.HasIndex(e => e.Abbreviation, "AK_Country_Abbreviation").IsUnique();

            entity.HasIndex(e => e.Name, "AK_Country_Name").IsUnique();

            entity.Property(e => e.CountryId)
                .ValueGeneratedNever()
                .HasColumnName("CountryID");
            entity.Property(e => e.Abbreviation)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(60);
            entity.Property(e => e.PhoneCode).HasMaxLength(50);
        });

        modelBuilder.Entity<Dictionary>(entity =>
        {
            entity.ToTable("Dictionary", "wordbook");

            entity.Property(e => e.DictionaryId)
                .ValueGeneratedNever()
                .HasColumnName("DictionaryID");
            entity.Property(e => e.Name).HasMaxLength(50);
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
                .HasConstraintName("FK_Follow_User-Followed");

            entity.HasOne(d => d.Follower).WithMany(p => p.FollowFollowers)
                .HasForeignKey(d => d.FollowerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Follow_User-Follower");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK_GroupOfMedia");

            entity.ToTable("Group", "medias");

            entity.Property(e => e.GroupId)
                .ValueGeneratedNever()
                .HasColumnName("GroupID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.GroupNavigation).WithOne(p => p.Group)
                .HasForeignKey<Group>(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupOfMedia_User");

            entity.HasMany(d => d.Media).WithMany(p => p.Groups)
                .UsingEntity<Dictionary<string, object>>(
                    "MediaGroup",
                    r => r.HasOne<Medium>().WithMany()
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MediaGroup_Media"),
                    l => l.HasOne<Group>().WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MediaGroup_Group"),
                    j =>
                    {
                        j.HasKey("GroupId", "MediaId");
                        j.ToTable("MediaGroup", "medias");
                    });
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.ToTable("Language", "location");

            entity.Property(e => e.LanguageId)
                .ValueGeneratedNever()
                .HasColumnName("LanguageID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Country).WithMany(p => p.Languages)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Language_Country");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("Login", "account");

            entity.HasIndex(e => e.Username, "AK_Login_Username").IsUnique();

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.PhoneId).HasColumnName("PhoneID");
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.User).WithOne(p => p.Login)
                .HasForeignKey<Login>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Login_User");
        });

        modelBuilder.Entity<Meaning>(entity =>
        {
            entity.HasKey(e => e.WordId);

            entity.ToTable("Meaning", "wordbook");

            entity.Property(e => e.WordId)
                .ValueGeneratedNever()
                .HasColumnName("WordID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Example).HasMaxLength(225);

            entity.HasOne(d => d.Word).WithOne(p => p.Meaning)
                .HasForeignKey<Meaning>(d => d.WordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Meaning_Word");
        });

        modelBuilder.Entity<MediaProgress>(entity =>
        {
            entity.HasKey(e => new { e.MediaId, e.ProgressId });

            entity.ToTable("MediaProgress", "medias");

            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.ProgressId).HasColumnName("ProgressID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Media).WithMany(p => p.MediaProgresses)
                .HasForeignKey(d => d.MediaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MediaProgress_Media");

            entity.HasOne(d => d.Progress).WithMany(p => p.MediaProgresses)
                .HasForeignKey(d => d.ProgressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MediaProgress_Progress");
        });

        modelBuilder.Entity<Medium>(entity =>
        {
            entity.HasKey(e => e.MediaId);

            entity.ToTable("Media", "medias");

            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.TypeOfMediaId).HasColumnName("TypeOfMediaID");

            entity.HasOne(d => d.TypeOfMedia).WithMany(p => p.Media)
                .HasForeignKey(d => d.TypeOfMediaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Media_Type");
        });

        modelBuilder.Entity<Phone>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("Phone", "account");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.CompletePhoneNumber).HasComputedColumnSql("(([CountryCodeID]+[DDD])+[Number])", false);
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
                .HasConstraintName("FK_Phone_User");
        });

        modelBuilder.Entity<Platform>(entity =>
        {
            entity.ToTable("Platform", "medias");

            entity.HasIndex(e => e.Name, "AK_Platform_Name").IsUnique();

            entity.Property(e => e.PlatformId)
                .ValueGeneratedNever()
                .HasColumnName("PlatformID");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasMany(d => d.Media).WithMany(p => p.Platforms)
                .UsingEntity<Dictionary<string, object>>(
                    "MediaPlatform",
                    r => r.HasOne<Medium>().WithMany()
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MediaPlatform_Media"),
                    l => l.HasOne<Platform>().WithMany()
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MediaPlatform_Platform"),
                    j =>
                    {
                        j.HasKey("PlatformId", "MediaId");
                        j.ToTable("MediaPlatform", "medias");
                    });
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.ToTable("Post", "publication");

            entity.Property(e => e.PostId)
                .ValueGeneratedNever()
                .HasColumnName("PostID");
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.VisibilityId).HasColumnName("VisibilityID");

            entity.HasOne(d => d.Visibility).WithMany(p => p.Posts)
                .HasForeignKey(d => d.VisibilityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Post_Visibility");

            entity.HasMany(d => d.TagOfPosts).WithMany(p => p.Posts)
                .UsingEntity<Dictionary<string, object>>(
                    "PostTag",
                    r => r.HasOne<Tag>().WithMany()
                        .HasForeignKey("TagOfPostId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PostTag_Tag"),
                    l => l.HasOne<Post>().WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PostTag_Post"),
                    j =>
                    {
                        j.HasKey("PostId", "TagOfPostId");
                        j.ToTable("PostTag", "publication");
                    });
        });

        modelBuilder.Entity<Progress>(entity =>
        {
            entity.HasKey(e => e.Progress1);

            entity.ToTable("Progress", "medias");

            entity.HasIndex(e => e.Name, "AK_Progress_Name").IsUnique();

            entity.Property(e => e.Progress1).HasColumnName("Progress");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.TypeId).HasColumnName("TypeID");

            entity.HasOne(d => d.Type).WithMany(p => p.Progresses)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Progress_Type");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.ToTable("Region", "location");

            entity.HasIndex(e => e.Abbreviation, "AK_Region_Abbreviation").IsUnique();

            entity.HasIndex(e => e.Name, "AK_Region_Name").IsUnique();

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.Abbreviation).HasMaxLength(50);
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.Name).HasMaxLength(60);

            entity.HasOne(d => d.Country).WithMany(p => p.Regions)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Region_Country");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("Settings", "account");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.PrimaryColor)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SecondaryColor)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.User).WithOne(p => p.Setting)
                .HasForeignKey<Setting>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Settings_User");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.ToTable("Tag", "publication");

            entity.Property(e => e.TagId)
                .ValueGeneratedNever()
                .HasColumnName("TagID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Tag1>(entity =>
        {
            entity.HasKey(e => e.TagId);

            entity.ToTable("Tag", "wordbook");

            entity.Property(e => e.TagId)
                .ValueGeneratedNever()
                .HasColumnName("TagID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Theme>(entity =>
        {
            entity.ToTable("Theme", "wordbook");

            entity.Property(e => e.ThemeId)
                .ValueGeneratedNever()
                .HasColumnName("ThemeID");
            entity.Property(e => e.DictionaryId).HasColumnName("DictionaryID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ParentThemeId).HasColumnName("ParentThemeID");

            entity.HasOne(d => d.Dictionary).WithMany(p => p.Themes)
                .HasForeignKey(d => d.DictionaryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Theme_Dictionary");

            entity.HasOne(d => d.ParentTheme).WithMany(p => p.InverseParentTheme)
                .HasForeignKey(d => d.ParentThemeId)
                .HasConstraintName("FK_Theme_Theme");
        });

        modelBuilder.Entity<Token>(entity =>
        {
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
                .HasConstraintName("FK_Token_Post");
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.ToTable("Type", "medias");

            entity.HasIndex(e => e.Name, "AK_Type_Name").IsUnique();

            entity.Property(e => e.TypeId)
                .ValueGeneratedNever()
                .HasColumnName("TypeID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
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

        modelBuilder.Entity<UserMediaTag>(entity =>
        {
            entity.HasKey(e => new { e.MediaId, e.UserId });

            entity.ToTable("UserMediaTag", "medias");

            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserTagId).HasColumnName("UserTagID");

            entity.HasOne(d => d.UserTag).WithMany(p => p.UserMediaTags)
                .HasForeignKey(d => d.UserTagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserMediaTag_UserTag");

            entity.HasOne(d => d.UserMedium).WithOne(p => p.UserMediaTag)
                .HasForeignKey<UserMediaTag>(d => new { d.MediaId, d.UserId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserMediaTag_UserMedia");
        });

        modelBuilder.Entity<UserMedium>(entity =>
        {
            entity.HasKey(e => new { e.MediaId, e.UserId });

            entity.ToTable("UserMedia", "medias");

            entity.Property(e => e.MediaId).HasColumnName("MediaID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.LinkDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.ProgressOfMediaId).HasColumnName("ProgressOfMediaID");

            entity.HasOne(d => d.Media).WithMany(p => p.UserMedia)
                .HasForeignKey(d => d.MediaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserMedia_Media");

            entity.HasOne(d => d.ProgressOfMedia).WithMany(p => p.UserMedia)
                .HasForeignKey(d => d.ProgressOfMediaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserMedia_Progress");

            entity.HasOne(d => d.User).WithMany(p => p.UserMedia)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserMedia_User");
        });

        modelBuilder.Entity<UserTag>(entity =>
        {
            entity.ToTable("UserTag", "medias");

            entity.Property(e => e.UserTagId).HasColumnName("UserTagID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserTags)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTag_User");
        });

        modelBuilder.Entity<Visibility>(entity =>
        {
            entity.ToTable("Visibility", "publication");

            entity.HasIndex(e => e.Name, "AK_Visibility_Name").IsUnique();

            entity.Property(e => e.VisibilityId)
                .ValueGeneratedNever()
                .HasColumnName("VisibilityID");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Word>(entity =>
        {
            entity.ToTable("Word", "wordbook");

            entity.Property(e => e.WordId).HasColumnName("WordID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ThemeId).HasColumnName("ThemeID");

            entity.HasOne(d => d.Theme).WithMany(p => p.Words)
                .HasForeignKey(d => d.ThemeId)
                .HasConstraintName("FK_Word_Theme");

            entity.HasMany(d => d.TagOfWords).WithMany(p => p.Words)
                .UsingEntity<Dictionary<string, object>>(
                    "WordTag",
                    r => r.HasOne<Tag1>().WithMany()
                        .HasForeignKey("TagOfWordId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_WordTag_Tag"),
                    l => l.HasOne<Word>().WithMany()
                        .HasForeignKey("WordId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_WordTag_Word"),
                    j =>
                    {
                        j.HasKey("WordId", "TagOfWordId");
                        j.ToTable("WordTag", "wordbook");
                    });
        });

        modelBuilder.Entity<WordRelation>(entity =>
        {
            entity.HasKey(e => new { e.WordId, e.ReferenceWordId, e.WordRelationTypeId });

            entity.ToTable("WordRelation", "wordbook");

            entity.Property(e => e.WordId).HasColumnName("WordID");
            entity.Property(e => e.ReferenceWordId).HasColumnName("ReferenceWordID");
            entity.Property(e => e.WordRelationTypeId).HasColumnName("WordRelationTypeID");

            entity.HasOne(d => d.ReferenceWord).WithMany(p => p.WordRelationReferenceWords)
                .HasForeignKey(d => d.ReferenceWordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WordRelation_Word-ReferenceWordID");

            entity.HasOne(d => d.Word).WithMany(p => p.WordRelationWords)
                .HasForeignKey(d => d.WordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WordRelation_Word-WordID");

            entity.HasOne(d => d.WordRelationType).WithMany(p => p.WordRelations)
                .HasForeignKey(d => d.WordRelationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WordRelation_WordRelationType");
        });

        modelBuilder.Entity<WordRelationType>(entity =>
        {
            entity.ToTable("WordRelationType", "wordbook");

            entity.Property(e => e.WordRelationTypeId)
                .ValueGeneratedNever()
                .HasColumnName("WordRelationTypeID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
