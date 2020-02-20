using AutoMapper;
using Blog.DAL.Entities;
using HomeTask.Models;
using System.Collections.Generic;

namespace HomeTask.Mapping
{
    public static class TagMapper
    {
        public static IEnumerable<TagViewModel> GetTagVM(IEnumerable<Tag> tags)
        {
            var config = new MapperConfiguration
                        (cfg => cfg.CreateMap<Tag, TagViewModel>());

            return config.CreateMapper().Map<IEnumerable<Tag>, IEnumerable<TagViewModel>>(tags);
        }
    }
}