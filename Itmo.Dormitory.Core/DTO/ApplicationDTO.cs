﻿using System;


namespace Itmo.Dormitory.Core.DTO
{
    public class ApplicationDTO
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string  Owner { get; set; }
        public bool Status { get; set; }
        public string ApplicationType { get; set; }
    }
}