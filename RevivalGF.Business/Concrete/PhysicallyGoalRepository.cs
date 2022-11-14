﻿using RevivalGF.DataAccess.Context;
using RevivalGF.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Business.Concrete
{
    public class PhysicallyGoalRepository : BaseRepository<PhysicallyGoal>
    {
        public PhysicallyGoalRepository(RevivalGfDbContext revivalGfDbContext) : base(revivalGfDbContext)
        {
        }
    }
}
