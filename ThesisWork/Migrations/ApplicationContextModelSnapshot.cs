﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThesisWork.Repository;

namespace ThesisWork.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThesisWork.Models.Competence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Описание");

                    b.Property<string>("ProfileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Название профиля");

                    b.Property<string>("Qalification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Квалификация");

                    b.Property<string>("VectorNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Номер направления подготовки ");

                    b.HasKey("Id");

                    b.ToTable("Компетенции");
                });

            modelBuilder.Entity("ThesisWork.Models.Practice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Building")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Дом");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Город");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Название компании");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Номер договора");

                    b.Property<string>("HeadOfPracticeFCs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ФИО руководителя предприятия");

                    b.Property<string>("HeadOfPracticePost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Должность руководителя предприятия");

                    b.Property<string>("Index")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Индекс");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Регион");

                    b.Property<string>("ResponsiblePersonFcs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ФИО Ответственнного лица");

                    b.Property<string>("ResponsiblePersonPost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Должность Ответственнного лица");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Улица");

                    b.HasKey("Id");

                    b.ToTable("Практики");
                });

            modelBuilder.Entity("ThesisWork.Models.PracticeSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Course")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Курс");

                    b.Property<string>("DirectorFcs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ФИО руководителя");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Количество недель");

                    b.Property<string>("EducationForm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Форма обучения");

                    b.Property<int>("ExamenHours")
                        .HasColumnType("int")
                        .HasColumnName("Часы на зачёт");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Дата окончания");

                    b.Property<int>("GroupNumber")
                        .HasColumnType("int")
                        .HasColumnName("Номер группы");

                    b.Property<int>("PracticeHours")
                        .HasColumnType("int")
                        .HasColumnName("Часы на практику");

                    b.Property<string>("PracticeKind")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Вид практики");

                    b.Property<string>("PracticeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Название практики");

                    b.Property<string>("PracticeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Тип практики");

                    b.Property<string>("Profile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Профиль");

                    b.Property<int>("Semester")
                        .HasColumnType("int")
                        .HasColumnName("Семестр");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Дата начала");

                    b.Property<int>("StudentsNumber")
                        .HasColumnType("int")
                        .HasColumnName("Кол-во студентов");

                    b.Property<string>("Vector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Направление");

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasColumnName("Учебный год");

                    b.HasKey("Id");

                    b.ToTable("График практик");
                });

            modelBuilder.Entity("ThesisWork.Models.Student", b =>
                {
                    b.Property<string>("GradeBookNumber")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Номер зачётной книжки");

                    b.Property<int>("CourseNumber")
                        .HasColumnType("int")
                        .HasColumnName("Курс");

                    b.Property<string>("EducationForm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Форма обучения");

                    b.Property<string>("Foreigner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Иностранец");

                    b.Property<string>("GroupNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Номер группы");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Имя");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Отчество");

                    b.Property<string>("SpecialtyNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Номер специальности");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Фамилия");

                    b.HasKey("GradeBookNumber");

                    b.ToTable("Студенты");
                });

            modelBuilder.Entity("ThesisWork.Models.Teacher", b =>
                {
                    b.Property<int>("TabNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FCs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ФИО");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Имя");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Уч. степень");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Отчество");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Контактный телефон");

                    b.Property<string>("Post")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Должность");

                    b.Property<string>("Rate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ставка");

                    b.Property<string>("StaffingLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Штатность");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Фамилия");

                    b.Property<string>("TeachersTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Звание");

                    b.HasKey("TabNumber");

                    b.ToTable("Преподаватели");
                });

            modelBuilder.Entity("ThesisWork.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FCs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ФИО");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Логин");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Имя");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Пароль");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Отчество");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Роль");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Фамилия");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}