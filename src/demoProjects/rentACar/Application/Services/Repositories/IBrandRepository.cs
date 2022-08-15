using Core.Persistence.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories
{
    //Brand'e özel operasyonlar buraya yazılacak
    //onion architecture - app katmanında unit test yazılır. asla Data Access'e gidilmez
    public interface IBrandRepository: IAsyncRepository<Brand>, IRepository<Brand>
    {
    }
}
