using Microsoft.EntityFrameworkCore;
using QuestionDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionDataLayer
{
    public class QuestionsContext : DbContext
    {
        public DbSet<QuestionModel> Questions { get; set; }
        public QuestionsContext(DbContextOptions<QuestionsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var questionModel = new QuestionModel
            {
                Id= 1,
                GroupId = Guid.Parse("3777d175-038c-4757-92e8-0c7e1fd677d5"),
                Name = "Опрос о качестве приложения",
                QuestionName = "Вам нравится приложение?"

            };
            modelBuilder.Entity<QuestionModel>().HasData(new QuestionModel[] { questionModel });
            base.OnModelCreating(modelBuilder);
        }
    }
}
