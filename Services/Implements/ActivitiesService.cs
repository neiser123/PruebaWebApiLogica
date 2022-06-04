using logica.Models;
using logica.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace logica.Services.Implements
{
   public class ActivitiesService :GenericService<Activities>,IActivitiesService
    {
        private readonly IActivitiesRepository activitiesRepository;
        public ActivitiesService(IActivitiesRepository activitiesRepository) : base(activitiesRepository)
        {
            this.activitiesRepository = activitiesRepository;
        }


        public async Task<bool> DeleteCheckOnEntry(int id)
        {
            return await activitiesRepository.DeleteCheckOnEntry(id);
        }
        public void DeleteAll(Activities activities)
        {
              activitiesRepository.DeleteAll(activities);
        }

        public void DeleteAll2(List<Activities> activities)
        {
            activitiesRepository.DeleteAll2(activities);
        }
    }
}
