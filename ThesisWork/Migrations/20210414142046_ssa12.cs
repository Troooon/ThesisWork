﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThesisWork.Migrations
{
    public partial class ssa12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Оценочная ведомость",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamenBookNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Оценка = table.Column<int>(type: "int", nullable: false),
                    Учебныйгод = table.Column<int>(name: "Учебный год", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Оценочная ведомость", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Практики",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Названиепрактики = table.Column<string>(name: "Название практики", type: "nvarchar(max)", nullable: false),
                    Типпрактики = table.Column<string>(name: "Тип практики", type: "nvarchar(max)", nullable: false),
                    Семестр = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Видпрактики = table.Column<string>(name: "Вид практики", type: "nvarchar(max)", nullable: false),
                    Колвонедель = table.Column<int>(name: "Кол-во недель", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Практики", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Преподаватели",
                columns: table => new
                {
                    TabNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Имя = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Фамилия = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Отчество = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ФИО = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Должность = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Учстепень = table.Column<string>(name: "Уч. степень", type: "nvarchar(max)", nullable: false),
                    Пароль = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ставка = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Штатность = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Контактныйтелефон = table.Column<string>(name: "Контактный телефон", type: "nvarchar(max)", nullable: false),
                    Звание = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Преподаватели", x => x.TabNumber);
                });

            migrationBuilder.CreateTable(
                name: "Профиль",
                columns: table => new
                {
                    Group = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Направление = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Названиепрофиля = table.Column<string>(name: "Название профиля", type: "nvarchar(max)", nullable: false),
                    ФГОС = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Профиль", x => x.Group);
                });

            migrationBuilder.CreateTable(
                name: "Специальности",
                columns: table => new
                {
                    Направление = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Наименованиенаправления = table.Column<string>(name: "Наименование направления", type: "nvarchar(max)", nullable: false),
                    Уровеньобразования = table.Column<string>(name: "Уровень образования", type: "nvarchar(max)", nullable: false),
                    Формаобучения = table.Column<string>(name: "Форма обучения", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Специальности", x => x.Направление);
                });

            migrationBuilder.CreateTable(
                name: "Студенты",
                columns: table => new
                {
                    Номерзачётнойкнижки = table.Column<string>(name: "Номер зачётной книжки", type: "nvarchar(450)", nullable: false),
                    Учгод = table.Column<string>(name: "Уч. год", type: "nvarchar(450)", nullable: false),
                    Фамилия = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Имя = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Отчество = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Номергруппы = table.Column<string>(name: "Номер группы", type: "nvarchar(max)", nullable: false),
                    Курс = table.Column<int>(type: "int", nullable: false),
                    Отделение = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Направление = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Староста = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Студенты", x => new { x.Номерзачётнойкнижки, x.Учгод });
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Имя = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Фамилия = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Отчество = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ФИО = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Логин = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Пароль = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Роль = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "График практик",
                columns: table => new
                {
                    IdГрафикапрактики = table.Column<int>(name: "Id Графика практики", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PracticeId = table.Column<int>(type: "int", nullable: true),
                    Учгод = table.Column<string>(name: "Уч. год", type: "nvarchar(max)", nullable: false),
                    Группы = table.Column<string>(name: "№ Группы", type: "nvarchar(max)", nullable: false),
                    Колвостудентов = table.Column<int>(name: "Кол-во студентов", type: "int", nullable: false),
                    ФИОРукПрактики = table.Column<string>(name: "ФИО Рук.Практики", type: "nvarchar(max)", nullable: false),
                    Направление = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Датаначала = table.Column<DateTime>(name: "Дата начала", type: "datetime2", nullable: false),
                    Датаконца = table.Column<DateTime>(name: "Дата конца", type: "datetime2", nullable: false),
                    Колвонедель = table.Column<int>(name: "Кол-во недель", type: "int", nullable: false),
                    ЧасыСРС = table.Column<float>(name: "Часы СРС", type: "real", nullable: false),
                    Аудиторныечасы = table.Column<float>(name: "Аудиторные часы", type: "real", nullable: false),
                    Часыназачёт = table.Column<float>(name: "Часы на зачёт", type: "real", nullable: false),
                    Лист = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_График практик", x => x.IdГрафикапрактики);
                    table.ForeignKey(
                        name: "FK_График практик_Практики_PracticeId",
                        column: x => x.PracticeId,
                        principalTable: "Практики",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Компетенции",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PracticeScheduleId = table.Column<int>(type: "int", nullable: true),
                    Компетенция = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Компетенции", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Компетенции_График практик_PracticeScheduleId",
                        column: x => x.PracticeScheduleId,
                        principalTable: "График практик",
                        principalColumn: "Id Графика практики",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PracticeBases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Учгод = table.Column<DateTime>(name: "Уч. год", type: "datetime2", nullable: false),
                    Группа = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentGradeBookNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StudentSudtingYear = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PracticeScheduleId = table.Column<int>(type: "int", nullable: true),
                    Названиеогранизации = table.Column<string>(name: "Название огранизации", type: "nvarchar(max)", nullable: false),
                    Индекс = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Регион = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Город = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Улица = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Дом = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Договора = table.Column<string>(name: "№ Договора ", type: "nvarchar(max)", nullable: false),
                    ФИОРуководителяпредприятия = table.Column<string>(name: "ФИО Руководителя предприятия", type: "nvarchar(max)", nullable: false),
                    Должностьруководителяпредприятия = table.Column<string>(name: "Должность руководителя предприятия", type: "nvarchar(max)", nullable: false),
                    ФИОответственногоотпрофильнойорганизации = table.Column<string>(name: "ФИО ответственного от профильной организации", type: "nvarchar(max)", nullable: false),
                    Должностьответственногоотпрофильнойорганизации = table.Column<string>(name: "Должность ответственного от профильной организации", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticeBases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PracticeBases_График практик_PracticeScheduleId",
                        column: x => x.PracticeScheduleId,
                        principalTable: "График практик",
                        principalColumn: "Id Графика практики",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PracticeBases_Студенты_StudentGradeBookNumber_StudentSudtingYear",
                        columns: x => new { x.StudentGradeBookNumber, x.StudentSudtingYear },
                        principalTable: "Студенты",
                        principalColumns: new[] { "Номер зачётной книжки", "Уч. год" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_График практик_PracticeId",
                table: "График практик",
                column: "PracticeId");

            migrationBuilder.CreateIndex(
                name: "IX_Компетенции_PracticeScheduleId",
                table: "Компетенции",
                column: "PracticeScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticeBases_PracticeScheduleId",
                table: "PracticeBases",
                column: "PracticeScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticeBases_StudentGradeBookNumber_StudentSudtingYear",
                table: "PracticeBases",
                columns: new[] { "StudentGradeBookNumber", "StudentSudtingYear" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Компетенции");

            migrationBuilder.DropTable(
                name: "Оценочная ведомость");

            migrationBuilder.DropTable(
                name: "Преподаватели");

            migrationBuilder.DropTable(
                name: "Профиль");

            migrationBuilder.DropTable(
                name: "Специальности");

            migrationBuilder.DropTable(
                name: "PracticeBases");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "График практик");

            migrationBuilder.DropTable(
                name: "Студенты");

            migrationBuilder.DropTable(
                name: "Практики");
        }
    }
}
