﻿using System;
using System.Collections.Generic;
using Model.DotNetCore.Enums;

namespace Model.DotNetCore.Entities
{
    public class Task : AuditableEntityBase
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public string Title { get; set; }
        public bool IsMyDay { get; set; }
        public bool IsImportant { get; set; }
        public DateTime? RemindDateUTC { get; set; }
        public DateTime? DueDateUTC { get; set; }
        public RepeatType RepeatType { get; set; }
        public byte? SelectedWeekDays { get; set; }
        public string Note { get; set; }

        public List<AccountTask> AccountTasks { get; set; }
        public List<Step> Steps { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}