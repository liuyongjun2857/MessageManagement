﻿using Message.Core.Repository;
using Message.Entity.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Message.IRepository
{
    public interface ISystemActionRepository : IMessageManagementRepository<SystemAction>
    {
    }
}
