using logica.Models;
using logica.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace logica.Services.Implements
{
   public class CoverphotosService : GenericService<Coverphotos>, ICoverphotosService
    {
        private readonly ICoverphotosRepository coverphotosRepository1;
        public CoverphotosService(ICoverphotosRepository coverphotosRepository) : base(coverphotosRepository)
        {
            this.coverphotosRepository1 = coverphotosRepository;

        }

        public void DeleteAll2(List<Coverphotos> Coverphotos)
        {
            coverphotosRepository1.DeleteAll2(Coverphotos);
        }
    }
}
