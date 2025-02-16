using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Framework.Constants;
using FluentMigrator;
using Migrations.Framework;

namespace Migrations
{
    public class _202502161400_creating_user_and_jobs : Migration
    {
        public override void Down()
        {
            Delete.Table(TableNameConstants.JobPostings);
            Delete.Table(TableNameConstants.Users);
        }

        public override void Up()
        {
            Create.Table(TableNameConstants.Companies)
                .WithCommonColumns()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Description").AsString(int.MaxValue).NotNullable()
                .WithColumn("Website").AsString().Nullable()
                .WithColumn("Logo").AsString().Nullable()
                .WithColumn("Email").AsString().NotNullable()
                .WithColumn("Phone").AsString().Nullable()
                .WithColumn("Address").AsString().Nullable()
                .WithColumn("City").AsString().Nullable()
                .WithColumn("State").AsString().Nullable()
                .WithColumn("Country").AsString().Nullable()
                .WithColumn("ZipCode").AsString().Nullable()
                .WithColumn("IsVerified").AsBoolean().NotNullable()
                .WithColumn("VerifiedAt").AsDateTime().Nullable()
                .WithColumn("UserId").AsInt32().NotNullable();


            Create.Table(TableNameConstants.JobPostings)
                .WithCommonColumns()
                .WithColumn("Title").AsString().NotNullable()
                .WithColumn("Slug").AsString().NotNullable().Unique()
                .WithColumn("Description").AsString(int.MaxValue).NotNullable()
                .WithColumn("HowToApply").AsString(int.MaxValue).NotNullable()
                .WithColumn("Location").AsString(int.MaxValue).NotNullable()
                .WithColumn("Level").AsInt32().NotNullable()
                .WithColumn("Type").AsInt32().NotNullable()
                .WithColumn("Commute").AsInt32().NotNullable()
                .WithColumn("Currency").AsInt32().NotNullable()
                .WithColumn("SalaryType").AsInt32().NotNullable()
                .WithColumn("Salary").AsDecimal().Nullable()
                .WithColumn("IsSalaryRanged").AsBoolean().NotNullable()
                .WithColumn("PostAsAnonymous").AsBoolean().NotNullable()
                .WithColumn("MinSalary").AsDecimal().Nullable()
                .WithColumn("MaxSalary").AsDecimal().Nullable()
                .WithColumn("CompanyId").AsInt32().ForeignKey(TableNameConstants.Companies, "Id").NotNullable();

        Create.Table(TableNameConstants.Users)
                .WithCommonColumns()
                .WithColumn("Name").AsString(50).NotNullable()
                .WithColumn("Email").AsString(100).NotNullable()
                .WithColumn("Password").AsString(256).NotNullable();
        }
    }
}
