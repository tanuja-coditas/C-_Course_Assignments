﻿using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models;

public partial class Student
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Department { get; set; }
}
