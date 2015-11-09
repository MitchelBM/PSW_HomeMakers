﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;

namespace PSW_HomeMakers.Models
{
    public class Post_Category
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        
        private int id_post;

        public int ID_Post
        {
            get { return id_post; }
            set { id_post = value; }
        }

        private int id_category;

        public int ID_Category
        {
            get { return id_category; }
            set { id_category = value; }
        }

    }
}