﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngine.Core.Abstraction.CQRS
{
    /// <summary>
    /// Contract to mark all queries
    /// </summary>
    public interface IQuery<out TResponse>
    {
    }
}
