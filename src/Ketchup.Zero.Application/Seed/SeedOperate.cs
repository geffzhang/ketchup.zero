﻿using Ketchup.Zero.Application.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ketchup.Zero.Application.Seed
{
    public class SeedOperate : IEntityTypeConfiguration<SysOperate>
    {
        public void Configure(EntityTypeBuilder<SysOperate> builder)
        {
            builder.HasData(new SysOperate()
            {
                Id = 1,
                Name = "添加",
                Remark = "1001"
            }, new SysOperate()
            {
                Id = 2,
                Name = "编辑",
                Remark = "1002"
            }, new SysOperate()
            {
                Id = 3,
                Name = "查询",
                Remark = "1003"
            }, new SysOperate()
            {
                Id = 4,
                Name = "删除",
                Remark = "1004"
            });
        }
    }
}
