//using System;
//using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

namespace Tescat1.Models.Data
{

    public partial class Pc
    {
        public Guid ID_PC { get; set; }

        public int? ID_USER { get; set; }

        public string? PC_TYPE { get; set; }

        public string? IP { get; set; }

        public string? PC_NAME { get; set; }

        public string? MODEL { get; set; }

        public string? USED_RAM_SLOTS { get; set; }

        public DateTime? LAST_MAINT { get; set; }

        public int? LAST_USER { get; set; }

        //[Timestamp]
        //public byte[]? Timestamp { get; set; }
    }
}