using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Models
{
    public interface IRepostory
    {

        List<Customers> Costomers { get; }
        Customers Get(int customerId);
    }



    public class Repostory : IRepostory
    {
        private List<Customers> _custmers;

        public Repostory()
        {
            _custmers = new List<Customers>() {
             new Customers(){CustomerId=1,FirsNamae="beşir", LastName="aydemir" ,  Role=Role.Admin, BirthDate=DateTime.Now  },
             new Customers(){CustomerId=2,FirsNamae="beşir", LastName="aydemir" , Role=Role.Meber ,BirthDate=DateTime.Now },
             new Customers(){CustomerId=3,FirsNamae="beşir", LastName="aydemir" ,Role=Role.User, BirthDate=DateTime.Now },
             new Customers(){CustomerId=4,FirsNamae="beşir", LastName="aydemir" , Role=Role.Admin,BirthDate=DateTime.Now }

                  };

           

        }

        public List<Customers> Costomers => _custmers;

        public List<Customers> Costners => throw new NotImplementedException();

        public Customers Get(int customerId) => _custmers.FirstOrDefault(i=>i.CustomerId==customerId);









    }
}
