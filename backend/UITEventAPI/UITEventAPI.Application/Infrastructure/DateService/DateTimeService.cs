﻿using UITEventAPI.Application.Common.Interfaces;

namespace UITEventAPI.Application.Infrastructure.DateTimeService;

public class DateTimeService : IDateTimeService
{
    public DateTime Now => DateTime.Now;
}
