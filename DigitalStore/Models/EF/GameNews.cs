﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalStore.Models.EF
{
    [Table("tb_GameNews")]
    public class GameNews : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CategoryID { get; set; }
        public int PublisherID { get; set; }
        public int GameID { get; set; }
        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [StringLength(250, ErrorMessage = "Tiêu đề không được vượt quá 250 ký tự")]
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeywords { get; set; }
        public bool IsActive { get; set; }

        public virtual NewsCategory NewsCategory { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual Game Game { get; set; }

    }
}