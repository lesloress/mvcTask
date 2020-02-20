using AutoMapper;
using Blog.DAL.Entities;
using HomeTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeTask.Mapping
{
    public static class CommentMapper
    {
        public static IEnumerable<CommentViewModel> GetCommentVM(IEnumerable<Comment> comments)
        {
            var config = new MapperConfiguration
                        (cfg => cfg.CreateMap<Comment, CommentViewModel>());

            return config.CreateMapper().Map<IEnumerable<Comment>, IEnumerable<CommentViewModel>>(comments);
        }
    }
}