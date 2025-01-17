﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YesilEvCodeFirst.Core.Entities
{
    public class BlackList : BaseEntity
    {
        [Key]
        public int BlackListID { get; set; }

        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User{ get; set; }

        public List<SupplementBlackList> SupplementBlackLists{ get; set; }
    }
}
