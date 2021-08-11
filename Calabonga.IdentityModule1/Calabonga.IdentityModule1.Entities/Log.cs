﻿using Calabonga.EntityFrameworkCore.Entities.Base;
using System;

namespace Calabonga.IdentityModule1.Entities
{
    /// <summary>
    /// Log entity for demo purposes only
    /// </summary>
    public class Log : Identity
    {
        public DateTime CreatedAt { get; set; }

        public string Logger { get; set; }

        public string Level { get; set; }

        public string Message { get; set; }

        public string ThreadId { get; set; }

        public string ExceptionMessage { get; set; }
    }
}
