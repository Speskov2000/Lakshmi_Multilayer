﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace Lakshmi.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ClientProfile ClientProfile { get; set; }
        public ICollection<Photo> Photos { get; set; } //Коллекция фотографий юзера
        public ICollection<Comment> Comments { get; set; }//Коллекция коментариев юзера
        public ICollection<Like> Likes { get; set; }//Коллекция лайков юзера
        public ApplicationUser()
        {
            Likes = new List<Like>();
            Photos = new List<Photo>();
            Comments = new List<Comment>();
        }
    }
        
}
