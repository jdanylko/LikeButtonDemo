using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LikeButtonDemo.Entities;

namespace LikeButtonDemo.ViewModels
{
    public class IndexViewModel
    {
        public Post Post { get; set; }
        public int PostLikes { get; set; }
    }
}
