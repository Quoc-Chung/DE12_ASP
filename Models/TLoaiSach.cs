﻿using System;
using System.Collections.Generic;

namespace MuoiHai_Limupa.Models;

public partial class TLoaiSach
{
    public string MaLoai { get; set; } = null!;

    public string? TenLoai { get; set; }

    public virtual ICollection<TSach> TSaches { get; set; } = new List<TSach>();
}
