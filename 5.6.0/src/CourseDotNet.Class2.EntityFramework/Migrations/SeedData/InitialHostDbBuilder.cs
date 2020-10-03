﻿using CourseDotNet.Class2.EntityFramework;
using EntityFramework.DynamicFilters;

namespace CourseDotNet.Class2.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly Class2DbContext _context;

        public InitialHostDbBuilder(Class2DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
