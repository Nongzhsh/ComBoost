﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Metadata;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Web.Mvc
{
    public interface IEntityMetadata
    {
        EntityMetadata Metadata { get; }
    }
}