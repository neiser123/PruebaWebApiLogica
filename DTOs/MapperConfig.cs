using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using logica.DTOs;
using logica.Models;


namespace logica.DTOs
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {

            return new MapperConfiguration(cfg => {

                cfg.CreateMap<Activities, ActivitiesDTO>();// GET
                cfg.CreateMap<ActivitiesDTO, Activities>(); // POST - PUT

                cfg.CreateMap<Authors, AuthorsDTO>();// GET
                cfg.CreateMap<AuthorsDTO, Authors>(); // POST - PUT

                cfg.CreateMap<Books, BooksDTO>();// GET
                cfg.CreateMap<BooksDTO, Books>(); // POST - PUT

                cfg.CreateMap<Coverphotos, CoverphotosDTO>();// GET
                cfg.CreateMap<CoverphotosDTO, Coverphotos>(); // POST - PUT


                cfg.CreateMap<Users,UsersDTO>();// GET
                cfg.CreateMap<UsersDTO, Users>(); // POST - PUT

            });

        }


    }
}
