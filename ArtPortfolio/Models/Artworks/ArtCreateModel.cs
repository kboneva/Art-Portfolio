﻿using System.ComponentModel.DataAnnotations;
using static ArtPortfolio.Data.DataConstants;

namespace ArtPortfolio.Models.Artworks
{
    public class ArtCreateModel
    {
        [Required]
        [MaxLength(TitleMaxLen, ErrorMessage = "Title field must be shorter than {1}")]
        [MinLength(TitleMinLen, ErrorMessage = "Title field must be longer than {1}")]
        public string Title { get; set; }
        
        [MaxLength(DescriptionMaxLen, ErrorMessage = "Description field must be shorter than {1}")]
        [MinLength(DescriptionMinLen, ErrorMessage = "Description field must be longer than {1}")]
        public string Description { get; set; }

        [Display(Name = "Image Url")]
        [Url]
        public string ImageUrl { get; set; }

    }
}