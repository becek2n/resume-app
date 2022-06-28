using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Resume.API.Migrations
{
    public partial class resumedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'16', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Group = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'16', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    UserName = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    FirstName = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Token = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    RefreshToken = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    JobTitle = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    NationalityId = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    DOB = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DOBPlace = table.Column<string>(type: "text", nullable: true),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    Hobbies = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Institution = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsCertified = table.Column<bool>(type: "boolean", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupTypeId = table.Column<int>(type: "integer", nullable: false),
                    School = table.Column<string>(type: "text", nullable: true),
                    Degree = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_GroupTypes_GroupTypeId",
                        column: x => x.GroupTypeId,
                        principalTable: "GroupTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Educations_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupTypeId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Company = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employments_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupTypeId = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    GroupTypeId1 = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languages_GroupTypes_GroupTypeId1",
                        column: x => x.GroupTypeId1,
                        principalTable: "GroupTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Languages_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Licences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Number = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Licences_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    SklillId = table.Column<int>(type: "integer", nullable: false),
                    GroupTypeId = table.Column<int>(type: "integer", nullable: false),
                    SkillId = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillSets_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillSets_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    ProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupTypeId = table.Column<int>(type: "integer", nullable: false),
                    AccountName = table.Column<string>(type: "text", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Socials_GroupTypes_GroupTypeId",
                        column: x => x.GroupTypeId,
                        principalTable: "GroupTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Socials_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GroupTypes",
                columns: new[] { "Id", "Description", "Group", "Icon", "Title" },
                values: new object[,]
                {
                    { 1, null, "Employment", null, "Employment" },
                    { 15, null, "Level", null, "Expert" },
                    { 14, null, "Level", null, "Advance" },
                    { 13, null, "Level", null, "Beginner" },
                    { 11, null, "Social", null, "LinkedIn" },
                    { 9, null, "Social", null, "Facebook" },
                    { 8, null, "Social", null, "Youtube" },
                    { 12, null, "Social", null, "Instagram" },
                    { 6, null, "Language", null, "Highly Proficient" },
                    { 5, null, "Language", null, "Native Speaker" },
                    { 4, null, "Education", null, "Non Formal" },
                    { 3, null, "Education", null, "Formal" },
                    { 2, null, "Employment", null, "Internship" },
                    { 7, null, "Language", null, "Very Good Command" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Description", "Icon", "Title" },
                values: new object[,]
                {
                    { 9, null, null, "Net Frameword" },
                    { 14, null, null, "Informix" },
                    { 13, null, null, "PostgreSQL" },
                    { 12, null, null, "Oracle" },
                    { 11, null, null, "Mysql" },
                    { 10, null, null, "SQL Server" },
                    { 8, null, null, "Netcore" },
                    { 1, null, null, "Python" },
                    { 6, null, null, "VB.NET" },
                    { 5, null, null, "C#" },
                    { 4, null, null, "C++" },
                    { 3, null, null, "C" },
                    { 2, null, null, "Golang" },
                    { 15, null, null, "DB2" },
                    { 7, null, null, ".NET" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateModified", "Email", "FirstName", "IsActive", "LastName", "ModifiedBy", "Password", "RefreshToken", "Token", "UserName" },
                values: new object[] { new Guid("365250ec-2eb5-4ae4-946e-19776b42e46b"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "januar.aransyah@gmail.com", "Januar", true, "Aransyah", null, null, null, null, "djanuar" });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Address", "CityId", "CountryId", "CreatedBy", "DOB", "DOBPlace", "DateModified", "Description", "Hobbies", "JobTitle", "ModifiedBy", "NationalityId", "Phone", "Photo", "PostalCode", "UserId" },
                values: new object[] { new Guid("c703219e-073e-406b-b1f0-ed689574e407"), "Pondok Sukmajaya Permai", 0, 0, null, new DateTime(1922, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bogor", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "saya seorang IT developer memiliki pengalaman lebih dari 7 tahun", null, "IT Developer", null, 0, "1233321", null, null, new Guid("365250ec-2eb5-4ae4-946e-19776b42e46b") });

            migrationBuilder.InsertData(
                table: "Employments",
                columns: new[] { "Id", "Address", "Company", "CreatedBy", "DateModified", "Description", "EndDate", "GroupTypeId", "ModifiedBy", "Phone", "ProfileId", "StartDate", "Title" },
                values: new object[,]
                {
                    { new Guid("836d32c4-7621-48bf-bcf2-92a8d0c404fe"), "Mampang Prapatan No. 100", "PT Asuransi Takaful Keluarga", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Analisa system, review project pengajuan", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "1233321", new Guid("c703219e-073e-406b-b1f0-ed689574e407"), new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manager Head of Business Analyst" },
                    { new Guid("a49245ad-924a-4458-8dcd-f87fa6a7532e"), "Kuningan", "PT Heksa Solution Insurance", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Membuat aplikasi baru, mengembangkan aplikasi yang ada pada core system", new DateTime(2019, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "1233321", new Guid("c703219e-073e-406b-b1f0-ed689574e407"), new DateTime(2014, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senior Officer - Developer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ProfileId",
                table: "Courses",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_GroupTypeId",
                table: "Educations",
                column: "GroupTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ProfileId",
                table: "Educations",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Employments_ProfileId",
                table: "Employments",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_GroupTypeId1",
                table: "Languages",
                column: "GroupTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_ProfileId",
                table: "Languages",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Licences_ProfileId",
                table: "Licences",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId",
                table: "Profiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillSets_ProfileId",
                table: "SkillSets",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillSets_SkillId",
                table: "SkillSets",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Socials_GroupTypeId",
                table: "Socials",
                column: "GroupTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Socials_ProfileId",
                table: "Socials",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email_UserName",
                table: "Users",
                columns: new[] { "Email", "UserName" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Employments");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Licences");

            migrationBuilder.DropTable(
                name: "SkillSets");

            migrationBuilder.DropTable(
                name: "Socials");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "GroupTypes");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
