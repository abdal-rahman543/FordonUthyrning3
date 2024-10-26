using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uthyrning.Databas;
using UthyrningSystem.Entiteter;
namespace Uthyrning.Affärslager
{
    public class StationService
    {
        private readonly StationRepository _repository;

        public StationService()
        {
            _repository = Custom_RepostioryContainer.GetRepository<StationRepository>();
        }

        public List<Station> HämtaStationer()
        {
            return _repository.HämtaStationer();
        }
    }
}
