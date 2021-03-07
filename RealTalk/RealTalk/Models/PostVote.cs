﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RealTalk.Models
{
    public class PostVote
    {
        [Key]
        public int Id { get; set; }

        public VoteType Type { get; set; }

        public ApplicationUser User { get; set; }

        public Post Post { get; set; }
    }
}