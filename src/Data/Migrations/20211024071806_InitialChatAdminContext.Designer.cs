﻿// <auto-generated />
using System;
using ChatAdmin.Bot.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ChatAdmin.Bot.Data.Migrations
{
    [DbContext(typeof(ChatAdminContext))]
    [Migration("20211024071806_InitialChatAdminContext")]
    partial class InitialChatAdminContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-rc.2.21480.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("ChatAdmin.Bot.Models.Accounting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("StartDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("start_date")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_date")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Id");

                    b.ToTable("accountings", "ca");
                });

            modelBuilder.Entity("ChatAdmin.Bot.Models.AuxiliaryWord", b =>
                {
                    b.Property<string>("Word")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("id");

                    b.Property<DateTime>("InsertDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("insert_date")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Word");

                    b.ToTable("auxiliary_words", "ca");
                });

            modelBuilder.Entity("ChatAdmin.Bot.Models.Ban", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("ChatId")
                        .HasColumnType("integer")
                        .HasColumnName("chat_id");

                    b.Property<DateTime?>("FinishDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("finish_date");

                    b.Property<DateTime>("InsertDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("insert_date")
                        .HasDefaultValueSql("now()");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_date")
                        .HasDefaultValueSql("now()");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.Property<int?>("WarningMessageId")
                        .HasColumnType("integer")
                        .HasColumnName("warning_message_id");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("UserId");

                    b.HasIndex("WarningMessageId");

                    b.ToTable("bans", "ca");
                });

            modelBuilder.Entity("ChatAdmin.Bot.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("Day")
                        .HasColumnType("integer")
                        .HasColumnName("day");

                    b.Property<DateTime?>("ExecDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("exec_date");

                    b.Property<int>("Hour")
                        .HasColumnType("integer")
                        .HasColumnName("hour");

                    b.Property<DateTime>("InsertDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("insert_date")
                        .HasDefaultValueSql("now()");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("message");

                    b.Property<int>("Minute")
                        .HasColumnType("integer")
                        .HasColumnName("minute");

                    b.Property<int?>("Month")
                        .HasColumnType("integer")
                        .HasColumnName("month");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_date")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Id");

                    b.ToTable("notifications", "ca");
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("ChatTypeId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("chat_type_id");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("description");

                    b.Property<DateTime>("InsertDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("insert_date")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<string>("RawData")
                        .IsRequired()
                        .HasColumnType("json")
                        .HasColumnName("raw_data");

                    b.Property<string>("RawDataHash")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("raw_data_hash");

                    b.Property<string>("RawDataHistory")
                        .HasColumnType("json")
                        .HasColumnName("raw_data_history");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_date")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Id");

                    b.HasIndex("ChatTypeId");

                    b.ToTable("chats", "bot");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            ChatTypeId = "PRIVATE",
                            Description = "IntegrationTestChat",
                            InsertDate = new DateTime(2021, 10, 24, 7, 18, 6, 583, DateTimeKind.Utc).AddTicks(9791),
                            Name = "IntegrationTestChat",
                            RawData = "{ \"test\": \"test\" }",
                            RawDataHash = "-1063294487",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 1,
                            ChatTypeId = "PRIVATE",
                            InsertDate = new DateTime(2021, 10, 24, 7, 18, 6, 583, DateTimeKind.Utc).AddTicks(9793),
                            Name = "zuev56",
                            RawData = "{ \"Id\": 210281448 }",
                            RawDataHash = "-1063294487",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.ChatType", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("chat_types", "bot");

                    b.HasData(
                        new
                        {
                            Id = "CHANNEL",
                            Name = "Channel"
                        },
                        new
                        {
                            Id = "GROUP",
                            Name = "Group"
                        },
                        new
                        {
                            Id = "PRIVATE",
                            Name = "Private"
                        },
                        new
                        {
                            Id = "UNDEFINED",
                            Name = "Undefined"
                        });
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.Command", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("id");

                    b.Property<string>("DefaultArgs")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("default_args");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("description");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("group");

                    b.Property<string>("Script")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("character varying(5000)")
                        .HasColumnName("script");

                    b.HasKey("Id");

                    b.ToTable("commands", "bot");

                    b.HasData(
                        new
                        {
                            Id = "/test",
                            Description = "Тестовый запрос к боту. Возвращает ''Test''",
                            Group = "moderatorCmdGroup",
                            Script = "SELECT 'Test'"
                        },
                        new
                        {
                            Id = "/nulltest",
                            Description = "Тестовый запрос к боту. Возвращает NULL",
                            Group = "moderatorCmdGroup",
                            Script = "SELECT null"
                        },
                        new
                        {
                            Id = "/help",
                            DefaultArgs = "<UserRoleId>",
                            Description = "Получение справки по доступным функциям",
                            Group = "userCmdGroup",
                            Script = "SELECT bot.sf_cmd_get_help({0})"
                        },
                        new
                        {
                            Id = "/sqlquery",
                            DefaultArgs = "select 'Pass your query as a parameter in double quotes'",
                            Description = "SQL-запрос",
                            Group = "adminCmdGroup",
                            Script = "select (with userQuery as ({0}) select json_agg(q) from userQuery q)"
                        },
                        new
                        {
                            Id = "/getuserstatistics",
                            DefaultArgs = "15; now()::Date; now()",
                            Description = "Получение статистики по активности участников всех чатов за определённый период",
                            Group = "adminCmdGroup",
                            Script = "SELECT string_agg(function_results.val, ' ') as Result\r\n                               FROM (\r\n                                   SELECT * FROM (\r\n                                       SELECT ca.sf_cmd_get_full_statistics({0}, {1}, {2}) as val, 1 as order\r\n                                       UNION\r\n                                       SELECT chr(10) || chr(10) || 'The most popular words:' || chr(10) || string_agg(w.word || ' (' || w.count || ')', ',  ') as val, 2 as order\r\n                                       FROM (SELECT * FROM ca.sf_get_most_popular_words(1, {1}, {2}, 2) LIMIT 10) w\r\n                                       UNION\r\n                                       SELECT chr(10) || chr(10) || 'Bans and warnings:' || chr(10) || string_agg(user_name || ' - ' || status, chr(10)) as val, 3 as order\r\n                                       FROM (SELECT * FROM ca.sf_get_bans(1, {1}, {2})) b\r\n                                   ) r\r\n                               ORDER BY r.order\r\n                               ) function_results"
                        });
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("ChatId")
                        .HasColumnType("integer")
                        .HasColumnName("chat_id");

                    b.Property<string>("FailDescription")
                        .HasColumnType("json")
                        .HasColumnName("fail_description");

                    b.Property<int>("FailsCount")
                        .HasColumnType("integer")
                        .HasColumnName("fails_count");

                    b.Property<DateTime>("InsertDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("insert_date")
                        .HasDefaultValueSql("now()");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bool")
                        .HasColumnName("is_deleted");

                    b.Property<bool>("IsSucceed")
                        .HasColumnType("bool")
                        .HasColumnName("is_succeed");

                    b.Property<string>("MessageTypeId")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("message_type_id");

                    b.Property<string>("MessengerId")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("messenger_id");

                    b.Property<string>("RawData")
                        .IsRequired()
                        .HasColumnType("json")
                        .HasColumnName("raw_data");

                    b.Property<string>("RawDataHash")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("raw_data_hash");

                    b.Property<string>("RawDataHistory")
                        .HasColumnType("json")
                        .HasColumnName("raw_data_history");

                    b.Property<int?>("ReplyToMessageId")
                        .HasColumnType("integer")
                        .HasColumnName("reply_to_message_id");

                    b.Property<string>("Text")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("text");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_date")
                        .HasDefaultValueSql("now()");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("MessageTypeId");

                    b.HasIndex("MessengerId");

                    b.HasIndex("ReplyToMessageId");

                    b.HasIndex("UserId");

                    b.ToTable("messages", "bot");
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.MessageType", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(3)
                        .HasColumnType("character varying(3)")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("message_types", "bot");

                    b.HasData(
                        new
                        {
                            Id = "UKN",
                            Name = "Unknown"
                        },
                        new
                        {
                            Id = "TXT",
                            Name = "Text"
                        },
                        new
                        {
                            Id = "PHT",
                            Name = "Photo"
                        },
                        new
                        {
                            Id = "AUD",
                            Name = "Audio"
                        },
                        new
                        {
                            Id = "VID",
                            Name = "Video"
                        },
                        new
                        {
                            Id = "VOI",
                            Name = "Voice"
                        },
                        new
                        {
                            Id = "DOC",
                            Name = "Document"
                        },
                        new
                        {
                            Id = "STK",
                            Name = "Sticker"
                        },
                        new
                        {
                            Id = "LOC",
                            Name = "Location"
                        },
                        new
                        {
                            Id = "CNT",
                            Name = "Contact"
                        },
                        new
                        {
                            Id = "SRV",
                            Name = "Service message"
                        },
                        new
                        {
                            Id = "OTH",
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.MessengerInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("messengers", "bot");

                    b.HasData(
                        new
                        {
                            Id = "TG",
                            Name = "Telegram"
                        },
                        new
                        {
                            Id = "VK",
                            Name = "Вконтакте"
                        },
                        new
                        {
                            Id = "SK",
                            Name = "Skype"
                        },
                        new
                        {
                            Id = "FB",
                            Name = "Facebook"
                        },
                        new
                        {
                            Id = "DC",
                            Name = "Discord"
                        });
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("full_name");

                    b.Property<DateTime>("InsertDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("insert_date")
                        .HasDefaultValueSql("now()");

                    b.Property<bool>("IsBot")
                        .HasColumnType("bool")
                        .HasColumnName("is_bot");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<string>("RawData")
                        .IsRequired()
                        .HasColumnType("json")
                        .HasColumnName("raw_data");

                    b.Property<string>("RawDataHash")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("raw_data_hash");

                    b.Property<string>("RawDataHistory")
                        .HasColumnType("json")
                        .HasColumnName("raw_data_history");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("update_date")
                        .HasDefaultValueSql("now()");

                    b.Property<string>("UserRoleId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("user_role_id");

                    b.HasKey("Id");

                    b.HasIndex("UserRoleId");

                    b.ToTable("users", "bot");

                    b.HasData(
                        new
                        {
                            Id = -10,
                            FullName = "for exported message reading",
                            InsertDate = new DateTime(2021, 10, 24, 7, 18, 6, 583, DateTimeKind.Utc).AddTicks(9817),
                            IsBot = false,
                            Name = "Unknown",
                            RawData = "{ \"test\": \"test\" }",
                            RawDataHash = "-1063294487",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserRoleId = "USER"
                        },
                        new
                        {
                            Id = -1,
                            FullName = "IntegrationTest",
                            InsertDate = new DateTime(2021, 10, 24, 7, 18, 6, 583, DateTimeKind.Utc).AddTicks(9819),
                            IsBot = false,
                            Name = "IntegrationTestUser",
                            RawData = "{ \"test\": \"test\" }",
                            RawDataHash = "-1063294487",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserRoleId = "USER"
                        },
                        new
                        {
                            Id = 1,
                            FullName = "Сергей Зуев",
                            InsertDate = new DateTime(2021, 10, 24, 7, 18, 6, 583, DateTimeKind.Utc).AddTicks(9820),
                            IsBot = false,
                            Name = "zuev56",
                            RawData = "{ \"Id\": 210281448 }",
                            RawDataHash = "-1063294487",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserRoleId = "OWNER"
                        });
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.UserRole", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<string>("Permissions")
                        .IsRequired()
                        .HasColumnType("json")
                        .HasColumnName("permissions");

                    b.HasKey("Id");

                    b.ToTable("user_roles", "bot");

                    b.HasData(
                        new
                        {
                            Id = "OWNER",
                            Name = "Owner",
                            Permissions = "[ \"All\" ]"
                        },
                        new
                        {
                            Id = "ADMIN",
                            Name = "Administrator",
                            Permissions = "[ \"adminCmdGroup\", \"moderatorCmdGroup\", \"userCmdGroup\" ]"
                        },
                        new
                        {
                            Id = "MODERATOR",
                            Name = "Moderator",
                            Permissions = "[ \"moderatorCmdGroup\", \"userCmdGroup\" ]"
                        },
                        new
                        {
                            Id = "USER",
                            Name = "User",
                            Permissions = "[ \"userCmdGroup\" ]"
                        });
                });

            modelBuilder.Entity("ChatAdmin.Bot.Models.Ban", b =>
                {
                    b.HasOne("Zs.Bot.Data.Models.Chat", "Chat")
                        .WithMany()
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zs.Bot.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zs.Bot.Data.Models.Message", "WarningMessage")
                        .WithMany()
                        .HasForeignKey("WarningMessageId");

                    b.Navigation("Chat");

                    b.Navigation("User");

                    b.Navigation("WarningMessage");
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.Chat", b =>
                {
                    b.HasOne("Zs.Bot.Data.Models.ChatType", "ChatType")
                        .WithMany("Chats")
                        .HasForeignKey("ChatTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatType");
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.Message", b =>
                {
                    b.HasOne("Zs.Bot.Data.Models.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zs.Bot.Data.Models.MessageType", "MessageType")
                        .WithMany("Messages")
                        .HasForeignKey("MessageTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zs.Bot.Data.Models.MessengerInfo", "Messenger")
                        .WithMany("Messages")
                        .HasForeignKey("MessengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Zs.Bot.Data.Models.Message", "ReplyToMessage")
                        .WithMany()
                        .HasForeignKey("ReplyToMessageId");

                    b.HasOne("Zs.Bot.Data.Models.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("MessageType");

                    b.Navigation("Messenger");

                    b.Navigation("ReplyToMessage");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.User", b =>
                {
                    b.HasOne("Zs.Bot.Data.Models.UserRole", "UserRoles")
                        .WithMany("Users")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.ChatType", b =>
                {
                    b.Navigation("Chats");
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.MessageType", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.MessengerInfo", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.User", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Zs.Bot.Data.Models.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}