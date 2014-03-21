﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace XenonCMS.ViewModels.Blog
{
    public class Create
    {
        [Required]
        public string Title { get; set; }
        public string Slug { get; set; }
        [Required, AllowHtml, Display(Name = "Content")]
        public string FullPostText { get; set; }
        [AllowHtml]
        public string PreviewText { get; set; }
    }
}