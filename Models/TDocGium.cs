﻿using System;
using System.Collections.Generic;

namespace MuoiHai_Limupa.Models;

public partial class TDocGium
{
    public string MaDg { get; set; } = null!;

    public string? HoDem { get; set; }

    public string? TenDg { get; set; }

    public string? SoCmnd { get; set; }

    public string? NoiCongTac { get; set; }

    public DateOnly? Ngaysinh { get; set; }

    public string? Anh { get; set; }
}
