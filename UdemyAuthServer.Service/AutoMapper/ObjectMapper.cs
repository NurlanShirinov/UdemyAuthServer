using AutoMapper;
using System;

namespace UdemyAuthServer.Service.AutoMapper
{

    //project run olundugu zaman bu method cagirilmmir yalniz bize lazim olan zaman cagirilir.
    public static class ObjectMapper
    {
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DtoMapper>();
            });
            return config.CreateMapper();
        });

        public static IMapper Mapper => lazy.Value;
    }
}