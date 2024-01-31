using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SecTestLsl.Models;

public partial class LifeShareLearnContext : DbContext
{
    public LifeShareLearnContext()
    {
    }

    public LifeShareLearnContext(DbContextOptions<LifeShareLearnContext> options)
        : base(options)
    {
    }

    public virtual DbSet<tAdmin> tAdmins { get; set; }

    public virtual DbSet<tCity> tCities { get; set; }

    public virtual DbSet<tCityDistrict> tCityDistricts { get; set; }

    public virtual DbSet<tCoupon> tCoupons { get; set; }

    public virtual DbSet<tCouponConditionList> tCouponConditionLists { get; set; }

    public virtual DbSet<tCourseField> tCourseFields { get; set; }

    public virtual DbSet<tCourseSubject> tCourseSubjects { get; set; }

    public virtual DbSet<tCoursework> tCourseworks { get; set; }

    public virtual DbSet<tCourseworkFile> tCourseworkFiles { get; set; }

    public virtual DbSet<tForumArticle> tForumArticles { get; set; }

    public virtual DbSet<tForumArticleComment> tForumArticleComments { get; set; }

    public virtual DbSet<tForumArticleTag> tForumArticleTags { get; set; }

    public virtual DbSet<tForumBoard> tForumBoards { get; set; }

    public virtual DbSet<tForumMember> tForumMembers { get; set; }

    public virtual DbSet<tForumMemberCollectArticle> tForumMemberCollectArticles { get; set; }

    public virtual DbSet<tForumMemberFloBoard> tForumMemberFloBoards { get; set; }

    public virtual DbSet<tForumMemberFloMember> tForumMemberFloMembers { get; set; }

    public virtual DbSet<tForumMemberFloTag> tForumMemberFloTags { get; set; }

    public virtual DbSet<tForumMod> tForumMods { get; set; }

    public virtual DbSet<tForumTag> tForumTags { get; set; }

    public virtual DbSet<tLessonBookVenue> tLessonBookVenues { get; set; }

    public virtual DbSet<tLessonCourse> tLessonCourses { get; set; }

    public virtual DbSet<tLessonCourseEvaluation> tLessonCourseEvaluations { get; set; }

    public virtual DbSet<tLessonCourseQA> tLessonCourseQAs { get; set; }

    public virtual DbSet<tMember> tMembers { get; set; }

    public virtual DbSet<tMemberCitiesList> tMemberCitiesLists { get; set; }

    public virtual DbSet<tMemberFavCourse> tMemberFavCourses { get; set; }

    public virtual DbSet<tMemberFavTeacher> tMemberFavTeachers { get; set; }

    public virtual DbSet<tMemberGetPush> tMemberGetPushes { get; set; }

    public virtual DbSet<tMemberLoginLog> tMemberLoginLogs { get; set; }

    public virtual DbSet<tMemberWishField> tMemberWishFields { get; set; }

    public virtual DbSet<tOrder> tOrders { get; set; }

    public virtual DbSet<tOrderDetail> tOrderDetails { get; set; }

    public virtual DbSet<tPushLayout> tPushLayouts { get; set; }

    public virtual DbSet<tPushMessage> tPushMessages { get; set; }

    public virtual DbSet<tServiceForm> tServiceForms { get; set; }

    public virtual DbSet<tShoppingCart> tShoppingCarts { get; set; }

    public virtual DbSet<tTeacher> tTeachers { get; set; }

    public virtual DbSet<tTeacherApplyLog> tTeacherApplyLogs { get; set; }

    public virtual DbSet<tTeacherEventLog> tTeacherEventLogs { get; set; }

    public virtual DbSet<tTeacherImage> tTeacherImages { get; set; }

    public virtual DbSet<tTeacherSubject> tTeacherSubjects { get; set; }

    public virtual DbSet<tVenue> tVenues { get; set; }

    public virtual DbSet<tVenueItemList> tVenueItemLists { get; set; }

    public virtual DbSet<tVenuePicList> tVenuePicLists { get; set; }

    public virtual DbSet<tVenueProviderInfo> tVenueProviderInfos { get; set; }

    public virtual DbSet<tVenueSubject> tVenueSubjects { get; set; }

    public virtual DbSet<tVenueTimeList> tVenueTimeLists { get; set; }

    public virtual DbSet<tVideoCourse> tVideoCourses { get; set; }

    public virtual DbSet<tVideoCourseEvaluation> tVideoCourseEvaluations { get; set; }

    public virtual DbSet<tVideoCourseQA> tVideoCourseQAs { get; set; }

    public virtual DbSet<tVideoUploadUrl> tVideoUploadUrls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Database=LifeShareLearn;Integrated Security=True;;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tAdmin>(entity =>
        {
            entity.HasKey(e => e.fEmployeeId).HasName("PK_tAdims");

            entity.Property(e => e.fEmployeeId).ValueGeneratedNever();
            entity.Property(e => e.fAdminJoinDate).HasColumnType("datetime");
            entity.Property(e => e.fAdminRole).HasMaxLength(50);
            entity.Property(e => e.fEmployeeEmail).HasMaxLength(50);
            entity.Property(e => e.fEmployeeName).HasMaxLength(50);
            entity.Property(e => e.fNote).HasMaxLength(50);
            entity.Property(e => e.fPassword).HasMaxLength(50);
        });

        modelBuilder.Entity<tCity>(entity =>
        {
            entity.HasKey(e => e.fCityId);

            entity.ToTable("tCity");

            entity.Property(e => e.fCityId).ValueGeneratedNever();
            entity.Property(e => e.fCityName).HasMaxLength(50);
        });

        modelBuilder.Entity<tCityDistrict>(entity =>
        {
            entity.HasKey(e => e.fDistrictId);

            entity.Property(e => e.fDistrictName).HasMaxLength(50);

            entity.HasOne(d => d.fCity).WithMany(p => p.tCityDistricts)
                .HasForeignKey(d => d.fCityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCityDistricts_tCity");
        });

        modelBuilder.Entity<tCoupon>(entity =>
        {
            entity.HasKey(e => e.fCouponId);

            entity.ToTable("tCoupon");

            entity.Property(e => e.fCouponCreatedDate).HasColumnType("date");
            entity.Property(e => e.fCouponDiscount).HasColumnType("money");
            entity.Property(e => e.fCouponEndDate).HasColumnType("date");
            entity.Property(e => e.fCouponStartDate).HasColumnType("date");
            entity.Property(e => e.fDiscountCode).HasMaxLength(50);

            entity.HasOne(d => d.fCouponCondition).WithMany(p => p.tCoupons)
                .HasForeignKey(d => d.fCouponConditionId)
                .HasConstraintName("FK_tCoupon_tCouponConditionList");
        });

        modelBuilder.Entity<tCouponConditionList>(entity =>
        {
            entity.HasKey(e => e.fCouponConditionId);

            entity.ToTable("tCouponConditionList");

            entity.Property(e => e.fCouponConditionName).HasMaxLength(50);

            entity.HasOne(d => d.fField).WithMany(p => p.tCouponConditionLists)
                .HasForeignKey(d => d.fField_Id)
                .HasConstraintName("FK_tCouponConditionList_tCourseFields");

            entity.HasOne(d => d.fSubject).WithMany(p => p.tCouponConditionLists)
                .HasForeignKey(d => d.fSubjectId)
                .HasConstraintName("FK_tCouponConditionList_tCourseSubjecs");

            entity.HasOne(d => d.fTeacher).WithMany(p => p.tCouponConditionLists)
                .HasForeignKey(d => d.fTeacherId)
                .HasConstraintName("FK_tCouponConditionList_tTeacher");
        });

        modelBuilder.Entity<tCourseField>(entity =>
        {
            entity.HasKey(e => e.fField_Id);

            entity.Property(e => e.fFieldCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.fFieldName).HasMaxLength(50);
        });

        modelBuilder.Entity<tCourseSubject>(entity =>
        {
            entity.HasKey(e => e.fSubjectId).HasName("PK_tCourseSubjecs");

            entity.Property(e => e.fSubjectCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.fSubjectName).HasMaxLength(50);

            entity.HasOne(d => d.fField).WithMany(p => p.tCourseSubjects)
                .HasForeignKey(d => d.fField_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourseSubjecs_tCourseFields");
        });

        modelBuilder.Entity<tCoursework>(entity =>
        {
            entity.HasKey(e => e.fCourseworkId);

            entity.ToTable("tCoursework");

            entity.Property(e => e.fCommentTime).HasColumnType("datetime");
            entity.Property(e => e.fLastModifyTime).HasColumnType("datetime");
            entity.Property(e => e.fName).HasMaxLength(50);
            entity.Property(e => e.fShareAudience).HasMaxLength(50);

            entity.HasOne(d => d.fOrderDetail).WithMany(p => p.tCourseworks)
                .HasForeignKey(d => d.fOrderDetail_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCoursework_tOrderDetail");
        });

        modelBuilder.Entity<tCourseworkFile>(entity =>
        {
            entity.HasKey(e => e.fCourseworkFileId);

            entity.ToTable("tCourseworkFile");

            entity.Property(e => e.fCourseworkFileId).ValueGeneratedNever();
            entity.Property(e => e.fFileFormat).HasMaxLength(50);
            entity.Property(e => e.fFileName).HasMaxLength(50);

            entity.HasOne(d => d.fCoursework).WithMany(p => p.tCourseworkFiles)
                .HasForeignKey(d => d.fCourseworkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourseworkFile_tCoursework");
        });

        modelBuilder.Entity<tForumArticle>(entity =>
        {
            entity.HasKey(e => e.fForumArticleId);

            entity.ToTable("tForumArticle");

            entity.Property(e => e.fForumArticleTime).HasColumnType("datetime");
            entity.Property(e => e.fForumLastEditArticleTime).HasColumnType("datetime");
            entity.Property(e => e.fForumTilte).HasMaxLength(50);

            entity.HasOne(d => d.fForumBoard).WithMany(p => p.tForumArticles)
                .HasForeignKey(d => d.fForumBoardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumArticle_tForumBoard");

            entity.HasOne(d => d.fForumMember).WithMany(p => p.tForumArticles)
                .HasForeignKey(d => d.fForumMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumArticle_tForumMember");
        });

        modelBuilder.Entity<tForumArticleComment>(entity =>
        {
            entity.HasKey(e => e.fForumCommentId);

            entity.ToTable("tForumArticleComment");

            entity.Property(e => e.fForumCommentTime).HasColumnType("datetime");
            entity.Property(e => e.fForumLastCommentEditTime).HasColumnType("datetime");
            entity.Property(e => e.fForumParentCommentId).HasDefaultValueSql("((-1))");
            entity.Property(e => e.fForumSubFloor).HasDefaultValueSql("((-1))");

            entity.HasOne(d => d.fForumArticle).WithMany(p => p.tForumArticleComments)
                .HasForeignKey(d => d.fForumArticleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumArticleComment_tForumArticle");

            entity.HasOne(d => d.fForumMember).WithMany(p => p.tForumArticleComments)
                .HasForeignKey(d => d.fForumMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumArticleComment_tForumMember");
        });

        modelBuilder.Entity<tForumArticleTag>(entity =>
        {
            entity.HasKey(e => e.fForumArticleTagId);

            entity.ToTable("tForumArticleTag");

            entity.HasOne(d => d.fForumArticle).WithMany(p => p.tForumArticleTags)
                .HasForeignKey(d => d.fForumArticleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumArticleTag_tForumArticle");

            entity.HasOne(d => d.fForumTag).WithMany(p => p.tForumArticleTags)
                .HasForeignKey(d => d.fForumTagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumArticleTag_tForumTag");
        });

        modelBuilder.Entity<tForumBoard>(entity =>
        {
            entity.HasKey(e => e.fSubjectId);

            entity.ToTable("tForumBoard");

            entity.Property(e => e.fSubjectId).ValueGeneratedNever();

            entity.HasOne(d => d.fSubject).WithOne(p => p.tForumBoard)
                .HasForeignKey<tForumBoard>(d => d.fSubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumBoard_tCourseSubjecs");
        });

        modelBuilder.Entity<tForumMember>(entity =>
        {
            entity.HasKey(e => e.fMemberId);

            entity.ToTable("tForumMember");

            entity.Property(e => e.fMemberId).ValueGeneratedNever();

            entity.HasOne(d => d.fMember).WithOne(p => p.tForumMember)
                .HasForeignKey<tForumMember>(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumMember_tMember");
        });

        modelBuilder.Entity<tForumMemberCollectArticle>(entity =>
        {
            entity.HasKey(e => e.fForumMemberCollectArticleId);

            entity.ToTable("tForumMemberCollectArticle");

            entity.HasOne(d => d.fForumArticle).WithMany(p => p.tForumMemberCollectArticles)
                .HasForeignKey(d => d.fForumArticleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumMemberCollectArticle_tForumArticle");

            entity.HasOne(d => d.fForumMember).WithMany(p => p.tForumMemberCollectArticles)
                .HasForeignKey(d => d.fForumMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumMemberCollectArticle_tForumMember");
        });

        modelBuilder.Entity<tForumMemberFloBoard>(entity =>
        {
            entity.HasKey(e => e.fForumMemberFloBoardId);

            entity.ToTable("tForumMemberFloBoard");

            entity.HasOne(d => d.fForumBoard).WithMany(p => p.tForumMemberFloBoards)
                .HasForeignKey(d => d.fForumBoardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumMemberFloBoard_tForumBoard");

            entity.HasOne(d => d.fForumMember).WithMany(p => p.tForumMemberFloBoards)
                .HasForeignKey(d => d.fForumMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumMemberFloBoard_tForumMember");
        });

        modelBuilder.Entity<tForumMemberFloMember>(entity =>
        {
            entity.HasKey(e => e.fForumMemberFloMemberId);

            entity.ToTable("tForumMemberFloMember");

            entity.HasOne(d => d.fForumIsFloMember).WithMany(p => p.tForumMemberFloMemberfForumIsFloMembers)
                .HasForeignKey(d => d.fForumIsFloMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumMemberFloMember_tForumMember1");

            entity.HasOne(d => d.fForumMember).WithMany(p => p.tForumMemberFloMemberfForumMembers)
                .HasForeignKey(d => d.fForumMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumMemberFloMember_tForumMember");
        });

        modelBuilder.Entity<tForumMemberFloTag>(entity =>
        {
            entity.HasKey(e => e.fForumMemberFloTagId);

            entity.ToTable("tForumMemberFloTag");

            entity.HasOne(d => d.fForumMember).WithMany(p => p.tForumMemberFloTags)
                .HasForeignKey(d => d.fForumMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumMemberFloTag_tForumMember");

            entity.HasOne(d => d.fForumTag).WithMany(p => p.tForumMemberFloTags)
                .HasForeignKey(d => d.fForumTagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumMemberFloTag_tForumTag");
        });

        modelBuilder.Entity<tForumMod>(entity =>
        {
            entity.HasKey(e => e.fForumModId);

            entity.ToTable("tForumMod");

            entity.HasOne(d => d.fForumBoard).WithMany(p => p.tForumMods)
                .HasForeignKey(d => d.fForumBoardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumMod_tForumBoard");

            entity.HasOne(d => d.fForumMember).WithMany(p => p.tForumMods)
                .HasForeignKey(d => d.fForumMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tForumMod_tForumMember");
        });

        modelBuilder.Entity<tForumTag>(entity =>
        {
            entity.HasKey(e => e.fForumTagId);

            entity.ToTable("tForumTag");
        });

        modelBuilder.Entity<tLessonBookVenue>(entity =>
        {
            entity.HasKey(e => e.fLessonBookVenueId);

            entity.ToTable("tLessonBookVenue");

            entity.Property(e => e.fBookDate).HasColumnType("date");
            entity.Property(e => e.fBookEnd).HasPrecision(0);
            entity.Property(e => e.fBookStart).HasPrecision(0);
            entity.Property(e => e.fBookStatusDesc).HasMaxLength(50);

            entity.HasOne(d => d.fLessonCourse).WithMany(p => p.tLessonBookVenues)
                .HasForeignKey(d => d.fLessonCourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tLessonBookVenue_tLessonCourse");

            entity.HasOne(d => d.fVenue).WithMany(p => p.tLessonBookVenues)
                .HasForeignKey(d => d.fVenueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tLessonBookVenue_tVenue");
        });

        modelBuilder.Entity<tLessonCourse>(entity =>
        {
            entity.HasKey(e => e.fLessonCourseId);

            entity.ToTable("tLessonCourse");

            entity.Property(e => e.fCode).HasMaxLength(50);
            entity.Property(e => e.fDescription).HasMaxLength(500);
            entity.Property(e => e.fHomeworkDescription).HasMaxLength(200);
            entity.Property(e => e.fLessonDate).HasColumnType("date");
            entity.Property(e => e.fLessonEndTime).HasPrecision(0);
            entity.Property(e => e.fLessonRegDeadline).HasColumnType("smalldatetime");
            entity.Property(e => e.fLessonRegStart).HasColumnType("smalldatetime");
            entity.Property(e => e.fLessonStartTime).HasPrecision(0);
            entity.Property(e => e.fLessonVenueInfo).HasMaxLength(50);
            entity.Property(e => e.fName).HasMaxLength(50);
            entity.Property(e => e.fNote).HasMaxLength(50);
            entity.Property(e => e.fPrice).HasColumnType("money");
            entity.Property(e => e.fRequirement).HasMaxLength(200);

            entity.HasOne(d => d.fSubject).WithMany(p => p.tLessonCourses)
                .HasForeignKey(d => d.fSubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tLessonCourse_tCourseSubjecs");

            entity.HasOne(d => d.fTeacher).WithMany(p => p.tLessonCourses)
                .HasForeignKey(d => d.fTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tLessonCourse_tTeacher");
        });

        modelBuilder.Entity<tLessonCourseEvaluation>(entity =>
        {
            entity.HasKey(e => e.fLessonEval_Id);

            entity.ToTable("tLessonCourseEvaluation");

            entity.Property(e => e.fComment).HasMaxLength(200);
            entity.Property(e => e.fCommentDate).HasColumnType("datetime");
            entity.Property(e => e.fCommentUpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.fLessonCourse).WithMany(p => p.tLessonCourseEvaluations)
                .HasForeignKey(d => d.fLessonCourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tLessonCourseEvaluation_tLessonCourse");

            entity.HasOne(d => d.fMember).WithMany(p => p.tLessonCourseEvaluations)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tLessonCourseEvaluation_tMember");
        });

        modelBuilder.Entity<tLessonCourseQA>(entity =>
        {
            entity.HasKey(e => e.fLessonQAId);

            entity.ToTable("tLessonCourseQA");

            entity.Property(e => e.fAnswer).HasMaxLength(200);
            entity.Property(e => e.fAnswerDate).HasColumnType("datetime");
            entity.Property(e => e.fPurpose).HasMaxLength(50);
            entity.Property(e => e.fQuestion).HasMaxLength(200);
            entity.Property(e => e.fQuestionDate).HasColumnType("datetime");

            entity.HasOne(d => d.fLessonCourse).WithMany(p => p.tLessonCourseQAs)
                .HasForeignKey(d => d.fLessonCourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tLessonCourseQA_tLessonCourse");

            entity.HasOne(d => d.fMember).WithMany(p => p.tLessonCourseQAs)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tLessonCourseQA_tMember");
        });

        modelBuilder.Entity<tMember>(entity =>
        {
            entity.HasKey(e => e.fMemberId);

            entity.ToTable("tMember");

            entity.Property(e => e.fBirthDate).HasColumnType("date");
            entity.Property(e => e.fEducation).HasMaxLength(50);
            entity.Property(e => e.fEmail).HasMaxLength(50);
            entity.Property(e => e.fJob).HasMaxLength(50);
            entity.Property(e => e.fNote).HasMaxLength(50);
            entity.Property(e => e.fPassword).HasMaxLength(50);
            entity.Property(e => e.fPhone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.fRealName).HasMaxLength(50);
            entity.Property(e => e.fRegisterDatetime).HasColumnType("datetime");
            entity.Property(e => e.fShowName).HasMaxLength(50);
        });

        modelBuilder.Entity<tMemberCitiesList>(entity =>
        {
            entity.HasKey(e => e.fMCitiesId).HasName("PK_tMemberCitesList");

            entity.ToTable("tMemberCitiesList");

            entity.HasOne(d => d.fCity).WithMany(p => p.tMemberCitiesLists)
                .HasForeignKey(d => d.fCityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tMemberCitesList_tCity");

            entity.HasOne(d => d.fMember).WithMany(p => p.tMemberCitiesLists)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tMemberCitesList_tMember");
        });

        modelBuilder.Entity<tMemberFavCourse>(entity =>
        {
            entity.HasKey(e => e.fMFavCId);

            entity.HasOne(d => d.fMember).WithMany(p => p.tMemberFavCourses)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tMemberFavCourses_tMember");
        });

        modelBuilder.Entity<tMemberFavTeacher>(entity =>
        {
            entity.HasKey(e => e.fMFavTId);

            entity.HasOne(d => d.fMember).WithMany(p => p.tMemberFavTeachers)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tMemberFavTeachers_tMember");

            entity.HasOne(d => d.fTeacher).WithMany(p => p.tMemberFavTeachers)
                .HasForeignKey(d => d.fTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tMemberFavTeachers_tTeacher");
        });

        modelBuilder.Entity<tMemberGetPush>(entity =>
        {
            entity.HasKey(e => e.fMemberGetPushId);

            entity.ToTable("tMemberGetPush");

            entity.Property(e => e.fPushCreatedTime).HasColumnType("datetime");

            entity.HasOne(d => d.fMember).WithMany(p => p.tMemberGetPushes)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tMemberGetPush_tMember");

            entity.HasOne(d => d.fPushMessage).WithMany(p => p.tMemberGetPushes)
                .HasForeignKey(d => d.fPushMessageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tMemberGetPush_tPushMessage");
        });

        modelBuilder.Entity<tMemberLoginLog>(entity =>
        {
            entity.HasKey(e => e.fLoginLogId);

            entity.ToTable("tMemberLoginLog");

            entity.Property(e => e.fLoginDateTime).HasColumnType("datetime");
            entity.Property(e => e.fLoginDevice).HasMaxLength(50);
            entity.Property(e => e.fLoginIP)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.fMember).WithMany(p => p.tMemberLoginLogs)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tMemberLoginLog_tMember");
        });

        modelBuilder.Entity<tMemberWishField>(entity =>
        {
            entity.HasKey(e => e.fMWishFieldsId);

            entity.HasOne(d => d.fField).WithMany(p => p.tMemberWishFields)
                .HasForeignKey(d => d.fField_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tMemberWishFields_tCourseFields");

            entity.HasOne(d => d.fMember).WithMany(p => p.tMemberWishFields)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tMemberWishFields_tMember");
        });

        modelBuilder.Entity<tOrder>(entity =>
        {
            entity.HasKey(e => e.fOrderId);

            entity.ToTable("tOrder");

            entity.Property(e => e.fAccountingTime).HasColumnType("datetime");
            entity.Property(e => e.fOrderTime).HasColumnType("datetime");
            entity.Property(e => e.fPaymentDeadline).HasColumnType("datetime");
            entity.Property(e => e.fPaymentInformation).HasMaxLength(50);
            entity.Property(e => e.fPaymentMethod).HasMaxLength(50);

            entity.HasOne(d => d.fCoupon).WithMany(p => p.tOrders)
                .HasForeignKey(d => d.fCouponId)
                .HasConstraintName("FK_tOrder_tCoupon");

            entity.HasOne(d => d.fMember).WithMany(p => p.tOrders)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tOrder_tMember");
        });

        modelBuilder.Entity<tOrderDetail>(entity =>
        {
            entity.HasKey(e => e.fOrderDetail_Id);

            entity.ToTable("tOrderDetail");

            entity.Property(e => e.fCoursePrice).HasColumnType("money");
            entity.Property(e => e.fDiscount).HasColumnType("money");
            entity.Property(e => e.fModificationDescription).HasMaxLength(50);

            entity.HasOne(d => d.fOrder).WithMany(p => p.tOrderDetails)
                .HasForeignKey(d => d.fOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tOrderDetail_tOrder");
        });

        modelBuilder.Entity<tPushLayout>(entity =>
        {
            entity.HasKey(e => e.fPushLayoutId);

            entity.ToTable("tPushLayout");

            entity.Property(e => e.fLayoutName).HasMaxLength(50);
        });

        modelBuilder.Entity<tPushMessage>(entity =>
        {
            entity.HasKey(e => e.fPushMessageId);

            entity.ToTable("tPushMessage");

            entity.Property(e => e.fPushCreatedTime).HasColumnType("datetime");
            entity.Property(e => e.fPushEndDate).HasColumnType("date");
            entity.Property(e => e.fPushLastUpdatedTime).HasColumnType("datetime");
            entity.Property(e => e.fPushMethod).HasMaxLength(50);
            entity.Property(e => e.fPushStartDate).HasColumnType("date");
            entity.Property(e => e.fPushType).HasMaxLength(50);

            entity.HasOne(d => d.fEmployee).WithMany(p => p.tPushMessages)
                .HasForeignKey(d => d.fEmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPushMessage_tAdmins");

            entity.HasOne(d => d.fPushLayout).WithMany(p => p.tPushMessages)
                .HasForeignKey(d => d.fPushLayoutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPushMessage_tPushLayout");
        });

        modelBuilder.Entity<tServiceForm>(entity =>
        {
            entity.HasKey(e => e.fServiceId);

            entity.ToTable("tServiceForm");

            entity.Property(e => e.fServiceChannel).HasMaxLength(50);
            entity.Property(e => e.fServiceClosedTime).HasColumnType("datetime");
            entity.Property(e => e.fServiceCreatedTime).HasColumnType("datetime");
            entity.Property(e => e.fServiceFormType).HasMaxLength(50);
            entity.Property(e => e.fServiceStatus).HasMaxLength(50);
            entity.Property(e => e.fServiceTag).HasMaxLength(50);
            entity.Property(e => e.fServiceType).HasMaxLength(50);

            entity.HasOne(d => d.fEmployee).WithMany(p => p.tServiceForms)
                .HasForeignKey(d => d.fEmployeeId)
                .HasConstraintName("FK_tServiceForm_tAdims");

            entity.HasOne(d => d.fMember).WithMany(p => p.tServiceForms)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tServiceForm_tMember");
        });

        modelBuilder.Entity<tShoppingCart>(entity =>
        {
            entity.HasKey(e => e.fShoppingCartId);

            entity.ToTable("tShoppingCart");

            entity.HasOne(d => d.fMember).WithMany(p => p.tShoppingCarts)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tShoppingCart_tMember");
        });

        modelBuilder.Entity<tTeacher>(entity =>
        {
            entity.HasKey(e => e.fTeacherId);

            entity.ToTable("tTeacher");

            entity.Property(e => e.fIntroduction).HasMaxLength(300);
            entity.Property(e => e.fJoinDatetime).HasColumnType("datetime");
            entity.Property(e => e.fNote).HasMaxLength(50);
            entity.Property(e => e.fTeacherName).HasMaxLength(50);

            entity.HasOne(d => d.fMember).WithMany(p => p.tTeachers)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTeacher_tMember");
        });

        modelBuilder.Entity<tTeacherApplyLog>(entity =>
        {
            entity.HasKey(e => e.fApplyLogId);

            entity.ToTable("tTeacherApplyLog");

            entity.Property(e => e.fApplyDatetime).HasColumnType("datetime");
            entity.Property(e => e.fContactInfo).HasMaxLength(50);
            entity.Property(e => e.fIntroduction).HasMaxLength(200);
            entity.Property(e => e.fNote).HasMaxLength(50);
            entity.Property(e => e.fPdfLink).HasMaxLength(100);
            entity.Property(e => e.fProgressStatus).HasMaxLength(50);
            entity.Property(e => e.fRealName).HasMaxLength(50);
            entity.Property(e => e.fReason).HasMaxLength(200);
            entity.Property(e => e.fReviewDatetime).HasColumnType("datetime");
            entity.Property(e => e.fTeacherPlanLink).HasMaxLength(100);

            entity.HasOne(d => d.fMember).WithMany(p => p.tTeacherApplyLogs)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTeacherApplyLog_tMember");
        });

        modelBuilder.Entity<tTeacherEventLog>(entity =>
        {
            entity.HasKey(e => e.fEventLogId);

            entity.ToTable("tTeacherEventLog");

            entity.Property(e => e.fDescription).HasMaxLength(300);
            entity.Property(e => e.fEmpRecordTime).HasColumnType("datetime");
            entity.Property(e => e.fEventType).HasMaxLength(50);

            entity.HasOne(d => d.fTeacher).WithMany(p => p.tTeacherEventLogs)
                .HasForeignKey(d => d.fTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTeacherEventLog_tTeacher");
        });

        modelBuilder.Entity<tTeacherImage>(entity =>
        {
            entity.HasKey(e => e.fTeacherImagesId);

            entity.Property(e => e.fImageName).HasMaxLength(50);

            entity.HasOne(d => d.fTeacher).WithMany(p => p.tTeacherImages)
                .HasForeignKey(d => d.fTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTeacherImages_tTeacher");
        });

        modelBuilder.Entity<tTeacherSubject>(entity =>
        {
            entity.HasKey(e => e.fTeacherSujectsId).HasName("PK_tTeacherSujects");

            entity.HasOne(d => d.fSubject).WithMany(p => p.tTeacherSubjects)
                .HasForeignKey(d => d.fSubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTeacherSujects_tCourseSubjecs");

            entity.HasOne(d => d.fTeacher).WithMany(p => p.tTeacherSubjects)
                .HasForeignKey(d => d.fTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTeacherSujects_tTeacher");
        });

        modelBuilder.Entity<tVenue>(entity =>
        {
            entity.HasKey(e => e.fVenueId);

            entity.ToTable("tVenue");

            entity.Property(e => e.fAddedTime).HasColumnType("date");
            entity.Property(e => e.fAddressDetail).HasMaxLength(50);
            entity.Property(e => e.fNote).HasMaxLength(50);
            entity.Property(e => e.fPriceHalfHr).HasColumnType("money");
            entity.Property(e => e.fVenueCode).HasMaxLength(50);
            entity.Property(e => e.fVenueName).HasMaxLength(50);

            entity.HasOne(d => d.fDistrict).WithMany(p => p.tVenues)
                .HasForeignKey(d => d.fDistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVenue_tCityDistricts");

            entity.HasOne(d => d.fVenueProvider).WithMany(p => p.tVenues)
                .HasForeignKey(d => d.fVenueProviderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVenue_tVenueProviderInfo");
        });

        modelBuilder.Entity<tVenueItemList>(entity =>
        {
            entity.HasKey(e => e.tVenueItemId);

            entity.ToTable("tVenueItemList");

            entity.Property(e => e.fItemName)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.fVenue).WithMany(p => p.tVenueItemLists)
                .HasForeignKey(d => d.fVenueId)
                .HasConstraintName("FK_tVenueItemList_tVenue");
        });

        modelBuilder.Entity<tVenuePicList>(entity =>
        {
            entity.HasKey(e => e.fVenuePicId);

            entity.ToTable("tVenuePicList");

            entity.HasOne(d => d.fVenue).WithMany(p => p.tVenuePicLists)
                .HasForeignKey(d => d.fVenueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVenuePicList_tVenue");
        });

        modelBuilder.Entity<tVenueProviderInfo>(entity =>
        {
            entity.HasKey(e => e.fVenueProviderId);

            entity.ToTable("tVenueProviderInfo");

            entity.Property(e => e.fContactName).HasMaxLength(50);
            entity.Property(e => e.fEmail).HasMaxLength(50);
            entity.Property(e => e.fGUInumber).HasMaxLength(50);
            entity.Property(e => e.fName).HasMaxLength(50);
            entity.Property(e => e.fPassword)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.fPhone).HasMaxLength(50);
        });

        modelBuilder.Entity<tVenueSubject>(entity =>
        {
            entity.HasKey(e => e.ftVenueSubjectId);

            entity.HasOne(d => d.fSubject).WithMany(p => p.tVenueSubjects)
                .HasForeignKey(d => d.fSubjectId)
                .HasConstraintName("FK_tVenueSubjects_tCourseSubjecs");

            entity.HasOne(d => d.fVenue).WithMany(p => p.tVenueSubjects)
                .HasForeignKey(d => d.fVenueId)
                .HasConstraintName("FK_tVenueSubjects_tVenue");
        });

        modelBuilder.Entity<tVenueTimeList>(entity =>
        {
            entity.HasKey(e => e.fVenueTimeId);

            entity.ToTable("tVenueTimeList");

            entity.Property(e => e.fChangeNote).HasMaxLength(50);
            entity.Property(e => e.fDate).HasColumnType("date");
            entity.Property(e => e.fTime).HasPrecision(0);

            entity.HasOne(d => d.fTeacher).WithMany(p => p.tVenueTimeLists)
                .HasForeignKey(d => d.fTeacherId)
                .HasConstraintName("FK_tVenueTimeList_tTeacher");

            entity.HasOne(d => d.fVenue).WithMany(p => p.tVenueTimeLists)
                .HasForeignKey(d => d.fVenueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVenueTimeList_tVenue");
        });

        modelBuilder.Entity<tVideoCourse>(entity =>
        {
            entity.HasKey(e => e.fVideoCourseId);

            entity.ToTable("tVideoCourse");

            entity.Property(e => e.fCode).HasMaxLength(20);
            entity.Property(e => e.fDescription).HasMaxLength(500);
            entity.Property(e => e.fHomeworkDescription).HasMaxLength(200);
            entity.Property(e => e.fName).HasMaxLength(50);
            entity.Property(e => e.fNote)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.fPrice).HasColumnType("money");
            entity.Property(e => e.fRequirement).HasMaxLength(200);
            entity.Property(e => e.fUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.fUploadDate).HasColumnType("datetime");
            entity.Property(e => e.fValidate).HasMaxLength(10);

            entity.HasOne(d => d.fSubject).WithMany(p => p.tVideoCourses)
                .HasForeignKey(d => d.fSubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVideoCourse_tCourseSubjecs");

            entity.HasOne(d => d.fTeacher).WithMany(p => p.tVideoCourses)
                .HasForeignKey(d => d.fTeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVideoCourse_tTeacher");
        });

        modelBuilder.Entity<tVideoCourseEvaluation>(entity =>
        {
            entity.HasKey(e => e.fVideoCourseEval_Id);

            entity.ToTable("tVideoCourseEvaluation");

            entity.Property(e => e.fComment).HasMaxLength(200);
            entity.Property(e => e.fCommentDate).HasColumnType("datetime");
            entity.Property(e => e.fCommentUpdateDate).HasColumnType("datetime");

            entity.HasOne(d => d.fMember).WithMany(p => p.tVideoCourseEvaluations)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVideoCourseEvaluation_tMember");

            entity.HasOne(d => d.fVideoCourse).WithMany(p => p.tVideoCourseEvaluations)
                .HasForeignKey(d => d.fVideoCourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVideoCourseEvaluation_tVideoCourse");
        });

        modelBuilder.Entity<tVideoCourseQA>(entity =>
        {
            entity.HasKey(e => e.fVideoCourseQAId);

            entity.ToTable("tVideoCourseQA");

            entity.Property(e => e.fAnswer).HasMaxLength(200);
            entity.Property(e => e.fAnswerDate).HasColumnType("datetime");
            entity.Property(e => e.fPurpose).HasMaxLength(50);
            entity.Property(e => e.fQuestion).HasMaxLength(200);
            entity.Property(e => e.fQuestionDate).HasColumnType("datetime");

            entity.HasOne(d => d.fMember).WithMany(p => p.tVideoCourseQAs)
                .HasForeignKey(d => d.fMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVideoCourseQA_tMember");

            entity.HasOne(d => d.fVideoCourse).WithMany(p => p.tVideoCourseQAs)
                .HasForeignKey(d => d.fVideoCourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVideoCourseQA_tVideoCourse");
        });

        modelBuilder.Entity<tVideoUploadUrl>(entity =>
        {
            entity.HasKey(e => e.fVideoUploadUrl_Id);

            entity.ToTable("tVideoUploadUrl");

            entity.Property(e => e.fUploadTime).HasColumnType("datetime");
            entity.Property(e => e.fVideoName).HasMaxLength(50);
            entity.Property(e => e.fVideoPath).HasMaxLength(200);

            entity.HasOne(d => d.fVideoCourse).WithMany(p => p.tVideoUploadUrls)
                .HasForeignKey(d => d.fVideoCourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVideoUploadUrl_tVideoCourse");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
